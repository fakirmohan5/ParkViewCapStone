using Microsoft.AspNetCore.Mvc;
using ParkView.Data;
using ParkView.Models.Domain;
using ParkView.Models;
using System.Security.Policy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Razorpay.Api;

namespace ParkView.Controllers
{
	public class GrandParkViewController : Controller
	{
        private readonly IHotel hotelRepo;
        private readonly ParkViewDbContext _context;



        public GrandParkViewController(IHotel hotelRepo, ParkViewDbContext dbContext)
        {
            this.hotelRepo = hotelRepo;
            this._context = dbContext;
        }


        [Authorize]
        public IActionResult Index(int RoomId, int hotelId)
        {
            var hotel = hotelRepo.GetHotelById(hotelId);

            var availableRoomTypes = hotelRepo.GetDistinctRoomTypesForHotel(hotelId);

            var bookingViewModel = new BookingViewModel
            {
                HotelId = hotelId,
                RoomId = RoomId,
                AvailableRoomTypes = availableRoomTypes,
            };

            return View(bookingViewModel);

        }


        [Authorize]
        [HttpGet]
        public IActionResult BookingConfirmation(BookingViewModel bookingViewModel)
        {

            //return View("BookingConfirmation", bookingView);
            return RedirectToAction("DetailsForm");
        }



        [Authorize]
        [HttpPost]
        public IActionResult BookRoom(BookingViewModel bookingViewModel, int hotelId, int roomId)
        {
            var hotel = hotelRepo.GetHotelById(hotelId);
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;


            if (hotel == null)
            {
                return NotFound();
            }

            if (!hotelRepo.IsRoomTypeAvailable(bookingViewModel.HotelId, bookingViewModel.RoomType, bookingViewModel.CheckInDate, bookingViewModel.CheckOutDate))
            {
                ModelState.AddModelError("RoomType", "The selected room type is not available for the specified dates.");
            }

            var room = _context.Room.FirstOrDefault(r => r.RoomId == roomId);

            bookingViewModel.RoomType = room.RoomType;



            int roomPrice = 1500; //hotelRepo.GetRoomPrice(bookingViewModel.HotelId, bookingViewModel.RoomType);
            int numberOfNights = (int)(bookingViewModel.CheckOutDate - bookingViewModel.CheckInDate).TotalDays;
            int totalPrice = 1500 * numberOfNights;//(roomPrice * numberOfNights);



            var booking = new Booking
            {
                UserId = userId,
                HotelId = bookingViewModel.HotelId,
                CheckInDate = bookingViewModel.CheckInDate,
                CheckOutDate = bookingViewModel.CheckOutDate,
                NumberOfGuests = bookingViewModel.NumberOfGuests,
                RoomType = bookingViewModel.RoomType,
                TotalPrice = totalPrice,
                BookingDate = DateTime.Now
            };

            _context.Bookings.Add(booking);
            _context.SaveChanges();

            return RedirectToAction("BookingConfirmation", bookingViewModel);

        }


        // Razor-Pay Payment Integration

        [BindProperty]
        public OrderEntity _OrderDetails { get; set; }

        public IActionResult DetailsForm()   // To take entries from Customer before payment initiation
        {

            return View();
        }

        public IActionResult InitiateOrder()
        {
            string key = "rzp_test_cgwSYT18Z5V2RG";         // Client -key & Client -secret from Razorpay 
            string secret = "VU2yLzBEjCn5Fw6vkMfx4El5";

            Random _random = new Random();
            string TransactionId = _random.Next(0, 10000).ToString();

            Dictionary<string, object> input = new Dictionary<string, object>();
            input.Add("amount", Convert.ToDecimal(_OrderDetails.TotalAmount) * 100);
            input.Add("currency", "INR");
            input.Add("receipt", TransactionId);



            RazorpayClient client = new RazorpayClient(key, secret);
            Razorpay.Api.Order order = client.Order.Create(input);

            ViewBag.orderid = order["id"].ToString();
            return View("Payment", _OrderDetails);

        }

        public IActionResult Payment(string razorpay_payment_id, string razorpay_order_id, string razorpay_signature)
        {
            Dictionary<string, string> attributes = new Dictionary<string, string>();
            attributes.Add("razorpay_payment_id", razorpay_payment_id);
            attributes.Add("razorpay_order_id", razorpay_order_id);
            attributes.Add("razorpay_signature", razorpay_signature);

            Utils.verifyPaymentSignature(attributes);
            OrderEntity orderdetails = new OrderEntity();
            orderdetails.TransactionId = razorpay_payment_id;
            orderdetails.OrderId = razorpay_order_id;
            return View("PaymentSuccess", orderdetails);

        }



        


    }
}

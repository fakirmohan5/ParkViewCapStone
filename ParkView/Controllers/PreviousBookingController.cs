using Microsoft.AspNetCore.Mvc;
using ParkView.Data;
using ParkView.Models.Domain;
using System.Security.Claims;



namespace ParkView.Controllers
{
    public class PreviousBookingController : Controller
    {
        private readonly ParkViewDbContext _context;



        public PreviousBookingController(ParkViewDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var previousBookings = GetPreviousBookingsFromDb();
            return View(previousBookings);
        }



        public List<Booking> GetPreviousBookingsFromDb()
        {
            var claimIdentity = (ClaimsIdentity)User.Identity;      // To fetch the user id of currently logged-in user
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var previousBookings = _context.Bookings.Where(b => b.UserId == userId).Select(b => new Booking
            {
                HotelId = b.HotelId,    
                Id = b.Id,
                RoomType = b.RoomType,
                CheckInDate = b.CheckInDate,
                CheckOutDate = b.CheckOutDate,
                NumberOfGuests = b.NumberOfGuests,
                BookingDate = b.BookingDate,
                TotalPrice = b.TotalPrice
            }).ToList();


            return previousBookings;

        }
    }
}
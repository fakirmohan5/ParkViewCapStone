using Microsoft.AspNetCore.Mvc;
using ParkView.Data;
using ParkView.Models;
using ParkView.Models.Domain;

using Microsoft.EntityFrameworkCore;

namespace ParkView.Controllers
{
	public class CabBookingController : Controller
	{
		private readonly ParkViewDbContext ParkViewDbContext;

		public CabBookingController( ParkViewDbContext parkViewDbContext )
		{
			ParkViewDbContext = parkViewDbContext;
		}

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<CabBooking> cabBooking = ParkViewDbContext.CabBooking.ToList();
            var carBooks = await ParkViewDbContext.CabBooks.ToListAsync();
            return View(cabBooking);



        }



        [HttpGet]
        public IActionResult Book()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Book(BookCabViewModel bookCabRequest)
        {
            var cabBook = new CabBook()
            {
                Id = Guid.NewGuid(),
                place = bookCabRequest.place,
                dateOfBooking = bookCabRequest.dateOfbookig
            };
            await ParkViewDbContext.CabBooks.AddAsync(cabBook);
            await ParkViewDbContext.SaveChangesAsync();
            return RedirectToAction("Book");
        }



        [HttpGet]
        public IActionResult BookCab()
        {

            var viewModel = new CabBookingViewModel();
            return View(viewModel);
        }



        [HttpPost]



        public IActionResult BookCab(CabBookingViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // Save cab booking data to the database.
                var cabBooking = new CabBooking
                {
                    UserId = "user123", // You may get the actual user ID here.
                    PickupLocation = viewModel.PickupLocation,
                    DropoffLocation = viewModel.DropoffLocation,
                    BookingTime = DateTime.Now,
                    Status = "Confirmed" // Set an initial status as needed.
                };
                ParkViewDbContext.CabBooking.Add(cabBooking);
                ParkViewDbContext.SaveChanges();



                // Save cab booking to the database (your database context code here).



                // Redirect to a confirmation page or perform other actions.
                return RedirectToAction("BookingConfirmation");
            }



            // If ModelState is not valid, return to the same view to display validation errors.
            return View(viewModel);
        }



    }
}

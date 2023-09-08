using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkView.Data;
using ParkView.Models;
using ParkView.Models.Domain;

namespace ParkView.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        //DI

        private readonly ParkViewDbContext _parkViewDbContext;
        private readonly AddHotelViewModel _addHotelViewModel;
        private readonly IHotel _hotel;

        public AdminController(ParkViewDbContext parkViewDbContext, IHotel hotel)
        {
            _parkViewDbContext = parkViewDbContext;
            _hotel = hotel;
        }

        // Show all added hotels
        public async Task<IActionResult> Index()
        {
            var hotels = await _parkViewDbContext.Hotels.ToListAsync();
            return View(hotels);
        }

        //show all registered users
        public async Task<IActionResult> RegisteredUsers()
        {
            var users = await _parkViewDbContext.Users.ToListAsync();
            return View(users);
        }

        //show all the bookings made on the website
        public IActionResult BookingsList()
        {
            //var bookings = await _parkViewDbContext.Bookings.ToListAsync();
            //return View(bookings);
            List<Booking> bookings = _parkViewDbContext.Bookings.ToList();
            return View(bookings);
        }


        // Add a new Hotel

        [HttpGet]
        public IActionResult AddHotel()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddHotel(AddHotelViewModel addHotelRequest)
        {
            var hotel = new Hotel()
            {
                Name = addHotelRequest.Name,
                Place = addHotelRequest.Place,
                NumRooms = addHotelRequest.NumRooms,
                NumPresedentialRooms = addHotelRequest.NumPresedentialRooms,
                NumDeluxeRooms = addHotelRequest.NumDeluxeRooms,
                NumExecutiveRooms = addHotelRequest.NumExecutiveRooms,
                NumSuperDeluxeRooms = addHotelRequest.NumSuperDeluxeRooms,
                imageUrl = addHotelRequest.ImageUrl
                

            };
            await _parkViewDbContext.Hotels.AddAsync(hotel);
            await _parkViewDbContext.SaveChangesAsync();     // updating DB
            return RedirectToAction("Index");

        }

        // View Page before Edt/Delete opearations
        [HttpGet]
        public async Task<IActionResult> View(int id)
        {
            var hotel = await _parkViewDbContext.Hotels.FirstOrDefaultAsync(h=>h.Id== id);
            if (hotel != null)
            {
                var viewmodel = new UpdateHotelViewModel()
                {
                    Id = hotel.Id,
                    Name = hotel.Name,
                    Place = hotel.Place,
                    NumRooms = hotel.NumRooms,
                    NumPresedentialRooms = hotel.NumPresedentialRooms,
                    NumDeluxeRooms = hotel.NumDeluxeRooms,
                    NumExecutiveRooms = hotel.NumExecutiveRooms,
                    NumSuperDeluxeRooms = hotel.NumSuperDeluxeRooms,
                    imageUrl = hotel.imageUrl
                };
                return await  Task.Run(()=> View("View",viewmodel));
            }
            
            return RedirectToAction("Index");
            
            
        }

        [HttpPost]
        public async Task<IActionResult> View(UpdateHotelViewModel model)
        {
            var hotel = await _parkViewDbContext.Hotels.FindAsync(model.Id);
            if (hotel != null)
            {
                hotel.Name = model.Name;
                hotel.Place = model.Place;
                hotel.NumRooms = model.NumRooms;
                hotel.NumExecutiveRooms=model.NumExecutiveRooms;
                hotel.NumPresedentialRooms=model.NumPresedentialRooms;  
                hotel.NumSuperDeluxeRooms=model.NumSuperDeluxeRooms;    
                hotel.NumDeluxeRooms= model.NumDeluxeRooms; 
                hotel.imageUrl = model.imageUrl;

                await _parkViewDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }


        // To delete any Hotel entry
        [HttpPost]
        public async Task<IActionResult> Delete(UpdateHotelViewModel model)
        {
            var hotel = await _parkViewDbContext.Hotels.FindAsync(model.Id);
            if (hotel != null)
            {
                _parkViewDbContext.Hotels.Remove(hotel);

                await _parkViewDbContext.SaveChangesAsync(); 
                
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }


    }
}

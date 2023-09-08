using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkView.Data;
using ParkView.Models;
using ParkView.Models.Domain;

namespace ParkView.Controllers
{
    public class HotelController : Controller
    {
        private readonly ParkViewDbContext _parkViewDbContext;
        private readonly IHotel _hotel;



        public HotelController(ParkViewDbContext parkViewDbContext, IHotel hotel)
        {
            _parkViewDbContext = parkViewDbContext;
            _hotel = hotel;
        }



        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var hotels = await _parkViewDbContext.Hotels.ToListAsync();

            return View(hotels);

        }





        

        public ActionResult ViewHotel(int id)
        {
            //var hotel = _hotel.GetDistinctRoomTypesForHotel
            var hotel = _hotel.GetHotelById(id);
            ViewData["currentHotelId"] = id;
            return View(hotel);
        }





        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }



        

    }
}

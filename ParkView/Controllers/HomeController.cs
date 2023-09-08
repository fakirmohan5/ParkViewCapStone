using Microsoft.AspNetCore.Mvc;
using ParkView.Models;
using ParkView.Models.Domain;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ParkView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		private readonly IHotel _hotelRepository;



		public HomeController(ILogger<HomeController> logger, IHotel hotelRepository)
		{
			_logger = logger;
			_hotelRepository = hotelRepository;
		}		


		

		

        public IActionResult Index(string query)
        {
            var searchResults = _hotelRepository.SearchHotels(query);  // Search operation based on title and place
            return View(searchResults);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
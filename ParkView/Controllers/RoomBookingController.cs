using Microsoft.AspNetCore.Mvc;
using ParkView.Data;
using ParkView.Models.Domain;
using ParkView.Models;
using Microsoft.EntityFrameworkCore;

namespace ParkView.Controllers
{
	
	public class RoomBookingController : Controller
	{
		private readonly ParkViewDbContext ParkViewDbContext;

		public RoomBookingController(ParkViewDbContext parkViewDbContext)
		{
			ParkViewDbContext = parkViewDbContext;
		}


		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var bookRooms = await ParkViewDbContext.BookRooms.ToListAsync();
			return View(bookRooms);

		}

		[HttpGet]

		public IActionResult BookRoom()
		{
			return View();
		}

	}
}

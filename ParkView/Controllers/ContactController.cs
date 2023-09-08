using Microsoft.AspNetCore.Mvc;

namespace ParkView.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

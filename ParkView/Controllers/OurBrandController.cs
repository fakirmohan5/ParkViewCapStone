using Microsoft.AspNetCore.Mvc;

namespace ParkView.Controllers
{
    public class OurBrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

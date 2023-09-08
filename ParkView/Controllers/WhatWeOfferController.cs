using Microsoft.AspNetCore.Mvc;

namespace ParkView.Controllers
{
    public class WhatWeOfferController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

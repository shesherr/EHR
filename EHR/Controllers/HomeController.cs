using System.Diagnostics;
using EHR.Models;
using Microsoft.AspNetCore.Mvc;

namespace EHR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult User()
        {
            return View();
        }
        public IActionResult Patient()
        {
            return View();
        }
        public IActionResult Appointment()
        {
            return View();
        }
        public IActionResult Prescription()
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

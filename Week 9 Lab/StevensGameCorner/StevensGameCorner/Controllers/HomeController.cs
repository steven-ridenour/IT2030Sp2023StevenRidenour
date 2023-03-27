using Microsoft.AspNetCore.Mvc;
using StevensGameCorner.Models;
using System.Diagnostics;

namespace StevensGameCorner.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Tools() 
        {
            HttpContext.Session.Remove("FirstName");
            HttpContext.Session.Remove("LastName");
            HttpContext.Session.Remove("Course");
            HttpContext.Session.Remove("FavNum");
            return View();
        }
        [HttpPost]
        public ViewResult Tools(MySession session)
        {
            HttpContext.Session.SetString("FirstName", "Steven");
            HttpContext.Session.SetString("LastName", "Ridenour");
            HttpContext.Session.SetString("Course", "IT2030");
            HttpContext.Session.SetInt32("FavNum", 22);
            return View();
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
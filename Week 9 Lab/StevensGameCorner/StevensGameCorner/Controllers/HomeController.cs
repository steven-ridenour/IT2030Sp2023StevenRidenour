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
        //### 6. Add two Tools action method to the HomeController –
        //one will set the four variables and the other will get the four variables and have the view display them.
        //In the first Tools action method, set the values for the four variables using FirstName, LastName, Course,and FavNum as the keys
        //and your first name, your last name, our course number IT2030, and your favorite number
        //as the corresponding values. When a user clicks the Display Session Variables button in the view, the assigned
        //values should display in the View’s input boxes. The second Tools action method should clear the values in the input boxes.
        [HttpGet]
        public IActionResult Tools() 
        {
            HttpContext.Session.SetString("FirstName", "Steven");
            HttpContext.Session.SetString("LastName", "Ridenour");
            HttpContext.Session.SetString("Course", "IT2030");
            HttpContext.Session.SetInt32("FavNum", 22);
            return View();
        }
        [HttpPost]
        [ActionName("Tools")]
        public ViewResult ToolsClear()
        {
            HttpContext.Session.Remove("FirstName");
            HttpContext.Session.Remove("LastName");
            HttpContext.Session.Remove("Course");
            HttpContext.Session.Remove("FavNum");
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
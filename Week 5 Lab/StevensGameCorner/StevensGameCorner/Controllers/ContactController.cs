using Microsoft.AspNetCore.Mvc;
using StevensGameCorner.Models;

namespace StevensGameCorner.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactModel model)
        {
            return View(model);
        }
    }

}


using Hotel.Atr.Saturday.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hotel.Atr.Saturday.Controllers
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

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        //public IActionResult Contact(string name, string email, string message)
        public IActionResult Contact(Message usermessage)
        {
            //if(string.IsNullOrWhiteSpace(usermessage.name))
            //{
            //    ModelState.AddModelError("name", "Поле обязательно для заполнения");
            //}

            if(ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View("Contact", usermessage);
            }
        }
    }
}
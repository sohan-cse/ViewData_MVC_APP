using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewData_MVC_App.Models;

namespace ViewData_MVC_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index_ViewData()
        {
            ViewData["Id"] = 101;
            ViewData["Name"] = "Laptop";
            ViewData["Price"] = 75000.00m;
            ViewData["Quantity"] = 5;
            return View();
        }
        public IActionResult Index_ViewBag()
        {
            ViewBag.Id = 201;
            ViewBag.Name = "PC";
            ViewBag.Price = 90000;
            ViewBag.Quantity = 10;
            return View();
        }

        public IActionResult Index_TempData()
        {
            ViewData["Id"] = 101;
            ViewData["Name"] = "Laptop";
            ViewData["Price"] = 75000.00m;
            ViewData["Quantity"] = 5;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

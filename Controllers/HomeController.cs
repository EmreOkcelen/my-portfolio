using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmreOkcelenCV.Models;

namespace EmreOkcelenCV.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Home / About Me Page
        public IActionResult Index()
        {
            return View();
        }

        // Privacy Page
        public IActionResult Privacy()
        {
            return View();
        }

        // Education Page
        public IActionResult Education()
        {
            return View();
        }

        // Experience Page
        public IActionResult Experience()
        {
            return View();
        }

        // Skills Page
        public IActionResult Skills()
        {
            return View();
        }

        // Projects Page
        public IActionResult Projects()
        {
            return View();
        }

        // Contact Page
        public IActionResult Contact()
        {
            return View();
        }

        // Error Page
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

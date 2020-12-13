using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpendFlix.Business.Services;
using SpendFlix.Mvc.Models;
using System.Diagnostics;

namespace SpendFlix.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _adminService;


        public HomeController(ILogger<HomeController> logger, IUserService adminService)
        {
            _logger = logger;
            _adminService = adminService;
        }

        public IActionResult Index()
        {            
            //_adminService.GetUsers();
            return View(_adminService.GetUsers());
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

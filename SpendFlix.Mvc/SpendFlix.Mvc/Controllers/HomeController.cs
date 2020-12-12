using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpendFlix.Mvc.Models;
using SpendFlix.Mvc.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SpendFlix.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAdminService _adminService;


        public HomeController(ILogger<HomeController> logger, IAdminService adminService)
        {
            _logger = logger;
            _adminService = adminService;
        }

        public IActionResult Index()
        {
            
            //_adminService.GetUsers();
            return View(_adminService.AddUser());
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

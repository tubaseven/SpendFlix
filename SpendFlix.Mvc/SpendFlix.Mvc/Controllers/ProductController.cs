using Microsoft.AspNetCore.Mvc;
using SpendFlix.Mvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpendFlix.Mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;


        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult GetProducts()
        {
            return View();
        }
    }
}

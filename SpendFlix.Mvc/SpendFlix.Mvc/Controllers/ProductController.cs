using Microsoft.AspNetCore.Mvc;
using SpendFlix.Business.Services;

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
            return View(_productService.GetProducts());
        }
    }
}

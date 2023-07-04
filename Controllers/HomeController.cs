using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WomanShop.Models;

namespace WomanShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductsStorage productsStorage;

        public HomeController(ProductsStorage _productsStorage)
        {
            productsStorage = _productsStorage;
        }
        public IActionResult Index()
        {
            return View(productsStorage.GetAll());
        }
    }
}
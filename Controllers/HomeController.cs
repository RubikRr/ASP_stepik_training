using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WomanShop.Interfaces;
using WomanShop.Models;
using WomanShop.Storages;

namespace WomanShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsStorage productsStorage;

        public HomeController(IProductsStorage _productsStorage)
        {
            productsStorage = _productsStorage;
        }
        public IActionResult Index()
        {
            return View(productsStorage.GetAll());
        }
    }
}
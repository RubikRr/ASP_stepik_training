using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WomanShop.Models;

namespace WomanShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductsStorage productStorage;

        public HomeController()
        {
            productStorage = new ProductsStorage();
        }
        public IActionResult Index()
        {
            return View(productStorage.GetAll());
        }
    }
}
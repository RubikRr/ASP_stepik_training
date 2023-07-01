using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WomanShop.Models;

namespace WomanShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductStorage productStorage;

        public HomeController()
        {
            productStorage = new ProductStorage();
        }
        public IActionResult Index()
        {
            return View(productStorage.GetAll());
        }
    }
}
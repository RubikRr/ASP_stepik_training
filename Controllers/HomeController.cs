using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WomanShop.Models;

namespace WomanShop.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {

            var products = new ProductStorage();
            return products.ToString();
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
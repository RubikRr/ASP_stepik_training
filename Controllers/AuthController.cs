using Microsoft.AspNetCore.Mvc;
using WomanShop.Models;

namespace WomanShop.Controllers
{
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Login(User user,string repeatedPassword)
        {
            return RedirectToAction("index", "home");

        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(User user, string repeatedPassword)
        {
            return RedirectToAction("index", "home");
        }
        public IActionResult Registration()
        {
            return View();
        }

    }
}

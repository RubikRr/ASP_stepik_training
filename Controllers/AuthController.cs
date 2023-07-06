using Microsoft.AspNetCore.Mvc;
using WomanShop.Models;

namespace WomanShop.Controllers
{
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Login(Login login)
        {
            return RedirectToAction("index", "home");

        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(Registration registration)
        {
            return RedirectToAction("index", "home");
        }
        public IActionResult Registration()
        {
            return View();
        }

    }
}

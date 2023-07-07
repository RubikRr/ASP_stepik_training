using Microsoft.AspNetCore.Mvc;
using WomanShop.Models;

namespace WomanShop.Controllers
{
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Login(Login login)
        {
            if(ModelState.IsValid)
                return RedirectToAction("index", "home");

            return View(login);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(Registration registration)
        {
            if(ModelState.IsValid)
                return RedirectToAction("index", "home");
            return View(registration);
        }
        public IActionResult Registration()
        {
            return View();
        }

    }
}

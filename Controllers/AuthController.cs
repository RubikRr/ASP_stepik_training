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

            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(Registration registration)
        {
            if(registration.Password==registration.Email)
            {
                ModelState.AddModelError("","Логин и пароль не должны совпадать");
            }
            if(ModelState.IsValid)
                return RedirectToAction("index", "home");
            return RedirectToAction("Registration");
        }
        public IActionResult Registration()
        {
            return View();
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using WomanShop.Models;

namespace WomanShop.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login(User user)
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}

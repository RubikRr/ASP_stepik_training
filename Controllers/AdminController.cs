using Microsoft.AspNetCore.Mvc;

namespace WomanShop.Controllers
{
    public class AdminController:Controller
    {
        public IActionResult Index(string str)
        {
            return View("index",str);
        }
    }
}

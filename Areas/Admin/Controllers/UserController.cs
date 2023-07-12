using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using WomanShop.Interfaces;
using WomanShop.Models;

namespace WomanShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private IUsersStorage usersStorage;

        public UserController(IUsersStorage _usersStorage)
        {
            usersStorage = _usersStorage;
        }

        public IActionResult Index()
        {
            var users = usersStorage.GetAll();
            return View(users);

        }

        public IActionResult Details(Guid userId)
        {
            var user = usersStorage.TryGetUserById(userId);
            return View(user);
        }

        public IActionResult Remove(Guid userId)
        {
            usersStorage.Remove(userId);
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
            if (ModelState.IsValid)
            {
                usersStorage.Add(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }
    }
}

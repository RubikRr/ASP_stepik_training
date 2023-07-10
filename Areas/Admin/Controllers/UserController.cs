using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using WomanShop.Interfaces;

namespace WomanShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController:Controller
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
    }
}

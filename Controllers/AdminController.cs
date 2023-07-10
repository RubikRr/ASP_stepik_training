using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WomanShop.Interfaces;
using WomanShop.Models;

namespace WomanShop.Controllers
{
    public class AdminController:Controller
    {
        private IProductsStorage productsStorage;
        private IRolesStorage rolesStorage;
        private IOrdersStorage ordersStorage;
        public AdminController(IProductsStorage _productsStorage, IRolesStorage _rolesStorage, IOrdersStorage _ordersStorage)
        {
            productsStorage = _productsStorage;
            rolesStorage = _rolesStorage;
            ordersStorage = _ordersStorage;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Orders()
        {
            var orders = ordersStorage.GetAll();
            return View(orders);
        }
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult Roles()
        {
            var roles=rolesStorage.GetAll();
            return View(roles);
        }
        public IActionResult Products()
        {
            var products = productsStorage.GetAll();
            return View(products);
        }
        public IActionResult RemoveRole(int roleId)
        {
            rolesStorage.Remove(roleId);
            return RedirectToAction("Roles");
        }
        [HttpPost]
        public IActionResult AddRole(Role role)
        {
            if (rolesStorage.IsInStorage(role))
            {
                ModelState.AddModelError("","Данная роль уже существуют.");
            }
            if (ModelState.IsValid)
            {
                rolesStorage.Add(role);
                return RedirectToAction("Roles");
            }
            return View(role);
        }
        public IActionResult AddRole()
        {
            return View();
        }
        public IActionResult RemoveProduct(int productId)
        {
            productsStorage.Remove(productId);
            return RedirectToAction("Products");
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                productsStorage.Add(product);
                return RedirectToAction("Products");
            }
            return View();
        }
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            if (ModelState.IsValid) 
            {
                productsStorage.Update(product);
                return RedirectToAction("Products");
            }
            return RedirectToAction("EditProduct");
        }
        public IActionResult EditProduct(int productId)
        {
            var product=productsStorage.TryGetById(productId);
            return View(product);
        }
        public IActionResult ShowOrder(Guid orderId)
        {
            var order = ordersStorage.TryGetById(orderId);
            return View(order);
        }
    }
}

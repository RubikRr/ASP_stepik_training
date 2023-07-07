using Microsoft.AspNetCore.Mvc;
using WomanShop.Interfaces;
using WomanShop.Models;

namespace WomanShop.Controllers
{
    public class AdminController:Controller
    {
        private IProductsStorage productsStorage;

        public AdminController(IProductsStorage _productsStorage)
        {
            productsStorage = _productsStorage;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Orders()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult Roles()
        {
            return View();
        }
        public IActionResult Products()
        {
            var products = productsStorage.GetAll();
            return View(products);
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
        public IActionResult EditProduct(int productId,Product product)
        {
            if (ModelState.IsValid) 
            {
                productsStorage.Edit(productId, product);
                return RedirectToAction("Products");
            }
            return RedirectToAction("EditProduct", productId);
        }
        public IActionResult EditProduct(int productId)
        {
            var product=productsStorage.TryGetById(productId);
            return View(product);
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WomanShop.Areas.Admin.Models;
using WomanShop.Interfaces;
using WomanShop.Models;

namespace WomanShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private IProductsStorage productsStorage;
        public ProductController(IProductsStorage _productsStorage)
        {
            productsStorage = _productsStorage;
        }

        public IActionResult Index()
        {
            var products = productsStorage.GetAll();
            return View(products);
        }
        public IActionResult Remove(int productId)
        {
            productsStorage.Remove(productId);
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                productsStorage.Add(product);
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Update(int productId)
        {
            var product = productsStorage.TryGetById(productId);
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                productsStorage.Update(product);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Update");
        }
    }
}

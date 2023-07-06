using Microsoft.AspNetCore.Mvc;
using WomanShop.Interfaces;
using WomanShop.Models;
using WomanShop.Storages;

namespace WomanShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductsStorage productsStorage;
        public ProductController(IProductsStorage _productsStorage)
        {
            productsStorage = _productsStorage;
        }
        public IActionResult Index(int id)
        {
            var product = productsStorage.TryGetById(id);
            //return product != null? product.ToString():$"Товар с индексом {id} не существует";
            return View(product);
        }

    }
}

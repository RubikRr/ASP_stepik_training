using Microsoft.AspNetCore.Mvc;

namespace WomanShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductsStorage productsStorage;
        public ProductController(ProductsStorage _productsStorage)
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

using Microsoft.AspNetCore.Mvc;

namespace WomanShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductsStorage productStorage;
        public ProductController()
        {
            productStorage = new ProductsStorage();
        }
        public IActionResult Index(int id)
        {
            var product = productStorage.TryGetById(id);
            //return product != null? product.ToString():$"Товар с индексом {id} не существует";
            return View(product);
        }
    }
}

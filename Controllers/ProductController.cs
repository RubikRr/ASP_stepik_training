using Microsoft.AspNetCore.Mvc;

namespace WomanShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductStorage productStorage;
        public ProductController()
        {
            productStorage = new ProductStorage();
        }
        public IActionResult Index(int id)
        {
            var product = productStorage.TryGetById(id);
            //return product != null? product.ToString():$"Товар с индексом {id} не существует";
            return View(product);
        }
    }
}

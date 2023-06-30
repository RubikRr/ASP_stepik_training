using Microsoft.AspNetCore.Mvc;

namespace WomanShop.Controllers
{
    public class ProductController : Controller
    {
        public string Index(int id)
        {

            var product = new ProductStorage()?.Products?.FirstOrDefault(pr => pr.Id == id);
            return product != null? product.ToString():"Товар с данным индексом не найден";
        }
    }
}

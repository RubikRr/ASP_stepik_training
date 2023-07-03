using Microsoft.AspNetCore.Mvc;
using WomanShop.Models;

namespace WomanShop.Controllers
{
    public class CartController:Controller
    {

        private  ProductsStorage productStorage { get; } = new ProductsStorage() ;
        public IActionResult Add(int productId)
        {
            var product = productStorage.TryGetById(productId);
            CartStorage.Add(Constants.UserId, product);
      
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var userCart = CartStorage.TryGetByUserId(Constants.UserId);
           
            return View(userCart);
        }
    }
}

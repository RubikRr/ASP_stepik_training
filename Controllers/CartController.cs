using Microsoft.AspNetCore.Mvc;
using WomanShop.Models;

namespace WomanShop.Controllers
{
    public class CartController:Controller
    {

        private ProductsStorage productStorage { get; }

        private CartStorage cartStorage { get; set; }

        public CartController(ProductsStorage _productsStorage,CartStorage _cartStorage)
        {
           productStorage = _productsStorage ;
           cartStorage = _cartStorage ;
        }
        public IActionResult Add(int productId)
        {
            var product = productStorage.TryGetById(productId);
            cartStorage.Add(Constants.UserId, product);
      
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var userCart = cartStorage.TryGetByUserId(Constants.UserId);
           
            return View(userCart);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using WomanShop.Interfaces;
using WomanShop.Models;
using WomanShop.Storages;

namespace WomanShop.Controllers
{
    public class CartController:Controller
    {

        private IProductsStorage productStorage { get; }

        private ICartsStorage cartStorage { get; set; }

        public CartController(IProductsStorage _productsStorage,ICartsStorage _cartStorage)
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

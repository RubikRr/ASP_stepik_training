using Microsoft.AspNetCore.Mvc;
using WomanShop.Interfaces;
using WomanShop.Models;
using WomanShop.Storages;

namespace WomanShop.Controllers
{
    public class CartController:Controller
    {

        private IProductsStorage productsStorage { get; }

        private ICartsStorage cartsStorage { get; set; }

        public CartController(IProductsStorage _productsStorage,ICartsStorage _cartStorage)
        {
           productsStorage = _productsStorage ;
           cartsStorage = _cartStorage ;
        }
        public IActionResult Add(int productId)
        {
            var product = productsStorage.TryGetById(productId);
            cartsStorage.Add(Constants.UserId, product);
      
            return RedirectToAction("Index");
        }


        public IActionResult Index()
        {
            var userCart = cartsStorage.TryGetByUserId(Constants.UserId);
           
            return View(userCart);
        }

        public IActionResult Clear()
        {
            
            cartsStorage.Clear(Constants.UserId);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeCount(Guid cartId,int productId, string act)
        {
            cartsStorage.Change(cartId, productId, act);
            return RedirectToAction("Index");
        }

        public IActionResult Checkout()
        {
            var cart = cartsStorage.TryGetByUserId(Constants.UserId);
            return View(cart);
        }

     
    }
}

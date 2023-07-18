using Microsoft.AspNetCore.Mvc;
using OnlineShop.DB.Interfaces;
using WomanShop.Helpers;
using WomanShop.Interfaces;
using WomanShop.Models;

namespace WomanShop.Controllers
{
    public class OrderController : Controller
    {
        private IOrdersStorage ordersStorage;

        private ICartsStorage cartsStorage;

        public OrderController(IOrdersStorage _ordersStorage, ICartsStorage _cartStorage)
        {
            ordersStorage = _ordersStorage;
            cartsStorage = _cartStorage;
        }
            
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Confirm(UserDeliveryInfoViewModel user)
        {
            if (ModelState.IsValid)
            {
                var cart = cartsStorage.TryGetByUserId(Constants.UserId);
                var order = new OrderViewModel(user,Mapping.ToCartItemsViewModel(cart.Items));
                ordersStorage.Add(order);
                //cartsStorage.Destroy(Constants.UserId);
                //cartsStorage.Clear(Constants.UserId);
                return View();
            }
            return RedirectToAction("Checkout", user);
        }

        public IActionResult Checkout()
        {
            //var cart=cartsStorage.TryGetByUserId(Constants.UserId);
            return View();
        }
    }
}

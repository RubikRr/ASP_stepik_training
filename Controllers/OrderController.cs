using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Confirm(UserDeliveryInfo user)
        {
            if (ModelState.IsValid)
            {
                var cart = cartsStorage.TryGetByUserId(Constants.UserId);
                var order = new Order
                {
                    DeliveryInfo = user,
                    Items = cart.Items
                };
                ordersStorage.Add(order);
                //cartsStorage.Destroy(Constants.UserId);
                cartsStorage.Clear(Constants.UserId);
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

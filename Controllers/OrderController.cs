using Microsoft.AspNetCore.Mvc;
using WomanShop.Interfaces;

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

        public IActionResult Confirm()
        {
            var cart = cartsStorage.TryGetByUserId(Constants.UserId);
            ordersStorage.Add(cart);
            //cartsStorage.Destroy(Constants.UserId);
            cartsStorage.Clear(Constants.UserId);
            return View();
        }

        public IActionResult Checkout()
        {
            var cart=cartsStorage.TryGetByUserId(Constants.UserId);
            return View(cart);
        }
    }
}

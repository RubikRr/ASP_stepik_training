using Microsoft.AspNetCore.Mvc;
using WomanShop.Interfaces;
using WomanShop.Models;

namespace WomanShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private IOrdersStorage ordersStorage;
        public OrderController(IOrdersStorage _ordersStorage)
        {
            ordersStorage = _ordersStorage;
        }
        public IActionResult Index()
        {
            var orders = ordersStorage.GetAll();
            return View(orders);
        }
        public IActionResult Details(Guid orderId)
        {
            var order = ordersStorage.TryGetById(orderId);
            return View(order);
        }
        [HttpPost]
        public IActionResult UpdateStatus(Guid orderId, OrderdStatus status)
        {
            ordersStorage.UpdateStatus(orderId, status);
            return RedirectToAction("Index");
        }
    }
}

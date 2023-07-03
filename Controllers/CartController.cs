using Microsoft.AspNetCore.Mvc;
using WomanShop.Models;

namespace WomanShop.Controllers
{
    public class CartController:Controller
    {

        private static CartStorage cartStorage { get; }=new CartStorage();
        private  ProductStorage productStorage { get; } = new ProductStorage() ;
        public IActionResult Index(int userId,int productId)
        {
            var userCart= cartStorage.TryGetByUserId(userId);
            if (userCart == null)
            {
                cartStorage.AddByUserId(userId);
                userCart = cartStorage.TryGetByUserId(userId);
            }

            userCart.Add(productStorage.TryGetById(productId));
            return View(userCart);
        }

        public IActionResult Show(int userId)
        {
            var userCart = cartStorage.TryGetByUserId(userId);
            if (userCart == null)
            {
                cartStorage.AddByUserId(userId);
                userCart = cartStorage.TryGetByUserId(userId);
            }
            return View("Index",userCart);
        }
    }
}

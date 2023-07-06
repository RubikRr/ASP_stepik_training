using Microsoft.AspNetCore.Mvc;
using WomanShop.Interfaces;

namespace WomanShop.Views.Shared.Components.Cart
{
    public class CartViewComponent:ViewComponent
    {
        private ICartsStorage cartsStorage;

        public CartViewComponent(ICartsStorage _cartsStorage)
        {
            cartsStorage = _cartsStorage;
        }

        public IViewComponentResult Invoke()
        {
            var cart = cartsStorage.TryGetByUserId(Constants.UserId);
            var ans= "";
            var productQuantity = (cart?.Quantity??0).ToString();
            if(productQuantity!="0")
                ans = productQuantity;
            return View("Cart",ans);
        }
    }
}

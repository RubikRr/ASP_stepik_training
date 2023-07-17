using Microsoft.AspNetCore.Mvc;
using OnlineShop.DB.Interfaces;
using WomanShop.Helpers;

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
            var cartModel = cartsStorage.TryGetByUserId(Constants.UserId);
            if (cartModel == null) { return View("Cart", "0"); }
            var cart=Mapping.ToCartViewModel(cartModel);
            
            var ans= "";
            var productQuantity = (cart?.Quantity??0).ToString();
            if(productQuantity!="0")
                ans = productQuantity;
            return View("Cart",ans);
        }
    }
}

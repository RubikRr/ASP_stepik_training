using WomanShop.Interfaces;
using WomanShop.Models;

namespace WomanShop.Storages
{
    public class InMemoryCartsStorage:ICartsStorage
    {
        private List<Cart> carts = new List<Cart>();
 
        public void Add(int userId, Product product)
        {
            var cart = carts.FirstOrDefault(cart => cart.UserId == userId);
            if (cart == null)
            {
                var newCart = new Cart(userId, product);
                carts.Add(newCart);
            }
            else
            {
                var existingCartItem = cart.Items.FirstOrDefault(item => item.Product.Id == product.Id);
                if (existingCartItem == null)
                {
                    cart.Items.Add(new CartItem(product));
                }
                else
                {
                    existingCartItem.Quantity++;
                }
            }
        }

        public void Change(Guid cartId, Guid cartItemId, string act)
        {
            var cart = carts.FirstOrDefault(cart => cart.Id == cartId);
            var cartItem=cart.Items.FirstOrDefault(item => item.Id == cartItemId);
            if (cartItem == null) { return; }
            if (act == "increase")
            {
                cartItem.Quantity++;
            }
            else if (act == "decrease") 
            {
                if (cartItem.Quantity == 1||cartItem.Quantity ==0)
                {
                    cart.Items.Remove(cartItem);
                }
                else
                {
                    cartItem.Quantity--;
                }
            }
        }
        public Cart TryGetByUserId(int userId)
        {
            return carts.FirstOrDefault(cart => cart.UserId == userId);
        }

        public Cart TryGetById(Guid cartId)
        {
            return carts.FirstOrDefault(cart => cart.Id == cartId);
        }

        public void Clear(int userId)
        {
            var cart=carts.FirstOrDefault(cart => cart.UserId == userId);
            cart.Items.Clear();
        }

        public void Destroy(int userId)
        {
            var cart=TryGetByUserId(userId);
            carts.Remove(cart);
        }

    }
}

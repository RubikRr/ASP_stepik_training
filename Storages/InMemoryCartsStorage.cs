using WomanShop.Interfaces;
using WomanShop.Models;

namespace WomanShop.Storages
{
    public class InMemoryCartsStorage:ICartsStorage
    {
        public List<Cart> carts { get; set; } = new List<Cart>();
 
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
                    existingCartItem.Count++;
                }
            }
        }
        public Cart TryGetByUserId(int userId)
        {
            return carts.FirstOrDefault(cart => cart.UserId == userId);
        }
    }
}

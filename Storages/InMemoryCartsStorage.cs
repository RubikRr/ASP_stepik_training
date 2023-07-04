using WomanShop.Interfaces;
using WomanShop.Models;

namespace WomanShop.Storages
{
    public class InMemoryCartsStorage:ICartsStorage
    {
        public List<Cart> Carts { get; set; }
        public InMemoryCartsStorage()
        {
            Carts = new List<Cart>();
        }
        public void Add(int userId, Product product)
        {
            var cart = Carts.FirstOrDefault(cart => cart.UserId == userId);
            if (cart == null)
            {
                var newCart = new Cart(userId, product);
                Carts.Add(newCart);
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
            return Carts.FirstOrDefault(cart => cart.UserId == userId);
        }
    }
}

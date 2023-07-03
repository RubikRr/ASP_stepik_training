using WomanShop.Models;

namespace WomanShop
{
    public class CartStorage
    {
        public List<Cart> Carts { get; set; } = new List<Cart>();

        public void AddByUserId(int userId)
        {
            if (!Carts.Any(cart=>cart.UserId==userId))
                  Carts.Add(new Cart(userId));
        }

        public void AddByUserIdAndCart(int userId, Cart cart) 
        {

        }

        public Cart TryGetByUserId(int userId) 
        {
            return Carts.FirstOrDefault(cart=>cart.UserId==userId);
        }
    }
}

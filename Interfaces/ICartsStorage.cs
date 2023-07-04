using WomanShop.Models;

namespace WomanShop.Interfaces
{
    public interface ICartsStorage
    {
        public List<Cart> Carts { get; set; }

        public void Add(int userId, Product product);

        public Cart TryGetByUserId(int userId);
        
    }
}

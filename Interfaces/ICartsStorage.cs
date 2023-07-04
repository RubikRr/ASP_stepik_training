using WomanShop.Models;

namespace WomanShop.Interfaces
{
    public interface ICartsStorage
    {

        public void Add(int userId, Product product);

        public Cart TryGetByUserId(int userId);
        
    }
}

using WomanShop.Models;

namespace WomanShop.Interfaces
{
    public interface ICartsStorage
    {

        public void Add(int userId, Product product);

        public Cart TryGetByUserId(int userId);

        public Cart TryGetById(Guid cartId);

        public void Clear(int userId);

        public void Change(Guid cartId, Guid cartItemId, string act);

        public void Destroy(int userId);

    }
}

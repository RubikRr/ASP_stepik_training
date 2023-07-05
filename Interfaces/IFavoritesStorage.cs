using WomanShop.Models;

namespace WomanShop.Interfaces
{
    public interface IFavoritesStorage
    {
        public Favorite TryGetByUserId(int userId);

        public void Add(int userId, Product product);
    }
}

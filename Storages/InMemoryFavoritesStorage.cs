using WomanShop.Interfaces;
using WomanShop.Models;

namespace WomanShop.Storages
{
    public class InMemoryFavoritesStorage:IFavoritesStorage
    {
        private List<Favorite> favorites = new List<Favorite>();
        public void Add(int userId,ProductViewModel product)
        {
            var favorite = TryGetByUserId(userId);
            if (favorite == null)
            {
                var newFavorite = new Favorite(userId);
                newFavorite.Products.Add(product);
                favorites.Add(newFavorite);
            }
            else 
            {
                var productInFav = favorite.Products.FirstOrDefault(pr => pr.Id == product.Id);
                if (productInFav == null)
                {
                    favorite.Products.Add(product);
                }
                else
                {
                    favorite.Products.Remove(productInFav);
                }
            }
        }

        public Favorite TryGetByUserId(int userId)
        {
            var favorite = favorites.FirstOrDefault(favorite => favorite.UserId == userId);
            return favorite;
        }
       
    }
}

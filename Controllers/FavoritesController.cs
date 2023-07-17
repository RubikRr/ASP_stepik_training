using Microsoft.AspNetCore.Mvc;
using OnlineShop.DB.Interfaces;
using WomanShop.Helpers;

namespace WomanShop.Controllers
{
    public class FavoritesController : Controller
    {
        private IProductsStorage productsStorage;
        private IFavoritesStorage favoritesStorage;

        public FavoritesController(IFavoritesStorage _favoritesStorage, IProductsStorage _productsStorage)
        {
            favoritesStorage = _favoritesStorage;
            productsStorage = _productsStorage;
        }
        public IActionResult Index()
        {
            var favorite = favoritesStorage.TryGetByUserId(Constants.UserId);
            return View(Mapping.ToFavoriteViewModel(favorite));
        }

        public IActionResult Add(Guid productId)
        {
            var product = productsStorage.TryGetById(productId);
            if (product == null) { return RedirectToAction("Index"); } 
            favoritesStorage.Add(Constants.UserId, product);
            return RedirectToAction("Index");
        }
    }
}

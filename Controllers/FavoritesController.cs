using Microsoft.AspNetCore.Mvc;
using WomanShop.Interfaces;

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
            return View(favorite);
        }

        public IActionResult Add(int productId)
        {
            var product = productsStorage.TryGetById(productId);
            if (product == null) { return RedirectToAction("Index"); } 
            favoritesStorage.Add(Constants.UserId, product);
            return RedirectToAction("Index");
        }
    }
}

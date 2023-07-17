using OnlineShop.DB.Models;
using WomanShop.Models;

namespace WomanShop.Helpers
{
    public static class Mapping
    {
        public static ProductViewModel ToProductViewModel(Product productModel)
        {
            return new ProductViewModel{
                Id = productModel.Id,
                Name = productModel.Name,
                Cost = productModel.Cost,
                Description = productModel.Description,
                ImagePath = productModel.ImagePath
            };
        }
        public static Product ToProductModel(ProductViewModel productViewModel)
        {
            return new Product
            {
                Id = productViewModel.Id,
                Name = productViewModel.Name,
                Cost = productViewModel.Cost,
                Description = productViewModel.Description,
                ImagePath = productViewModel.ImagePath
            };
        }
        public static List<ProductViewModel> ToProductsViewModel(List<Product> productsModel)
        {
            var ans = productsModel.Select(ToProductViewModel).ToList();
            return ans;
        }

        public static CartItemViewModel ToCartItemViewModel(CartItem cartItemModel) 
        {
            return new CartItemViewModel {
                Product=ToProductViewModel(cartItemModel.Product),
                Quantity=cartItemModel.Quantity
            };
        }
        public static List<CartItemViewModel> ToCartItemsViewModel(List<CartItem> cartItemsModel)
        {
            var ans = cartItemsModel?.Select(ToCartItemViewModel)?.ToList() ??null;
            return ans;
        }

        public static CartViewModel ToCartViewModel(Cart cartModel)
        {
            return new CartViewModel
            {
                Id = cartModel.Id,
                Items= ToCartItemsViewModel(cartModel.Items),
                UserId=cartModel.UserId
            };
        }

        public static FavoriteViewModel ToFavoriteViewModel(Favorite favoriteModel)
        {
            return new FavoriteViewModel
            {
                Id=favoriteModel.Id,
                UserId=favoriteModel.UserId,
                Products=ToProductsViewModel(favoriteModel.Products)
            };
        }
    }
}

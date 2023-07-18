using OnlineShop.DB.Models;
using WomanShop.Models;

namespace WomanShop.Helpers
{
    public static class Mapping
    {
        public static ProductViewModel ToProductViewModel(Product productModel)
        {
            if (productModel != null)
            {  
                return new ProductViewModel{
                    Id = productModel.Id,
                    Name = productModel.Name,
                    Cost = productModel.Cost,
                    Description = productModel.Description,
                    ImagePath = productModel.ImagePath
                };
            }
            return null;

        }
        public static Product ToProductModel(ProductViewModel productViewModel)
        {
            if (productViewModel != null)
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
            return null;
        }
        public static List<ProductViewModel> ToProductsViewModel(List<Product> productsModel)
        {
            var ans = productsModel.Select(ToProductViewModel).ToList();
            return ans;
        }

        public static CartItemViewModel ToCartItemViewModel(CartItem cartItemModel) 
        {
            if (cartItemModel != null)
            {  
                return new CartItemViewModel {
                    Product=ToProductViewModel(cartItemModel.Product),
                    Quantity=cartItemModel.Quantity
                };
            }
            return null;

        }
        public static List<CartItemViewModel> ToCartItemsViewModel(List<CartItem> cartItemsModel)
        {
            var ans = cartItemsModel?.Select(ToCartItemViewModel)?.ToList() ??null;
            return ans;
        }

        public static CartViewModel ToCartViewModel(Cart cartModel)
        {
            if (cartModel != null)
            {
                return new CartViewModel
                {
                    Id = cartModel.Id,
                    Items = ToCartItemsViewModel(cartModel.Items),
                    UserId = cartModel.UserId
                };
            }
            return null;
            
        }
    }
}

using WomanShop.Models;

namespace WomanShop.Interfaces
{
    public interface IProductsStorage
    {
        public List<Product> Products { get; init; }

        public List<Product> GetAll();

        public Product TryGetById(int id);
    }
}

using WomanShop.Models;

namespace WomanShop.Interfaces
{
    public interface IProductsStorage
    {
        public List<Product> GetAll();

        public Product TryGetById(int id);
    }
}

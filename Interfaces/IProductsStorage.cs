using WomanShop.Models;

namespace WomanShop.Interfaces
{
    public interface IProductsStorage
    {
        public List<Product> GetAll();
        public Product TryGetById(int id);
        public void Remove(int productId);
        public void Add(Product product);
        public void Edit(int productId, Product product);
    }
}

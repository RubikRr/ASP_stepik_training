using System.Text;
using WomanShop.Interfaces;
using WomanShop.Models;

namespace WomanShop.Storages
{
    public class InMemoryProductsStorage : IProductsStorage
    {
        private readonly List<Product> products = new List<Product>()
        {
            new Product("Пиджак",2500,"Женский пиджак","/images/products/image1.png"),
            new Product("Кеды",5000,"Кеды на лето","/images/products/image2.png"),
            new Product("Блузка",3000,"Блузка для офиса","/images/products/image3.png"),
            new Product("Платье",5000,"Платье на вечер","/images/products/image4.png"),
            new Product("Сапоги",5000,"Сапоги на лето","/images/products/image5.jpg"),
            new Product("Майка",5000,"Майка с Пухлей", "/images/products/image6.jpg"),
            new Product("Платье",4000,"Женское платье","/images/products/image7.jpg"),
            new Product("Кеды",5000,"Кеды на лето","/images/products/image1.png")
        };

        public List<Product> GetAll() => products;
        public void Add(Product product)
        {
            var newProduct = new Product(product.Name,product.Cost,product.Description,product.ImagePath);
            products.Add(newProduct);   
        }
        public void Edit(int productId,Product product)
        {
            var productInStorage = this.TryGetById(productId);
            productInStorage.Name = product.Name;
            productInStorage.Cost = product.Cost;
            productInStorage.Description = product.Description;
            productInStorage.ImagePath=product.ImagePath;
        }
        public List<Product> Search(string name)
        {
            var searchProducts = products.Where(product => product.Name.ToLower().StartsWith(name.ToLower())).ToList();
            return searchProducts;
        }
        public void Remove(int productId)
        {
            products.RemoveAll(product => product.Id == productId);
        }
        public Product TryGetById(int id)
        {
           return products.FirstOrDefault(pr => pr.Id == id);
        }
    }
}
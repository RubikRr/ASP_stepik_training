using System.Text;
using WomanShop.Models;

namespace WomanShop
{
    public class ProductsStorage
    {
        static private List<Product> products = new List<Product>() {
                new Product("Пиджак",2500,"Женский пиджак","/images/products/image1.png"),
                new Product("Кеды",5000,"Кеды на лето","/images/products/image2.png"),
                new Product("Блузка",3000,"Блузка для офиса","/images/products/image3.png"),
                new Product("Платье",5000,"Платье на вечер","/images/products/image4.png"),
                new Product("Сапоги",5000,"Сапоги на лето","/images/products/image5.jpg"),
                new Product("Майка",5000,"Майка с Пухлей", "/images/products/image6.jpg"),
                new Product("Платье",4000,"Женское платье","/images/products/image7.jpg"),
                new Product("Кеды",5000,"Кеды на лето","/images/products/image1.png")};

        public List<Product> GetAll() => products;

        public Product TryGetById(int id) => products.FirstOrDefault(pr => pr.Id == id);

        public string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in products)
            {
                sb.Append(item.ToString());
            }
            return sb.ToString();
        }
    }
}

using System.Text;
using WomanShop.Models;

namespace WomanShop
{
    public class ProductStorage
    {
        static private List<Product> products = new List<Product>() {
                new Product("Пиджак",2500,"Женский пиджак"),
                new Product("Кеды",5000,"Кеды на лето"),
                new Product("Блузка",3000,"Блузка для офиса"),
                new Product("Платье",5000,"Платье на вечер"),
                new Product("Сапоги",5000,"Сапоги на лето"),
                new Product("Майка",5000,"Майка с Пухлей"),
                new Product("Платье",4000,"Женское платье"),
                 new Product("Кеды",5000,"Кеды на лето"),};

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

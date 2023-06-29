using System.Text;

namespace WomanShop
{
    public class ProductStorage
    {
        public List<Product> Products { get; set; }

        public ProductStorage()
        {
            Products = new List<Product>() 
            {
                new Product(0,"Пиджак",2500,"Женский пиджак"),
                new Product(1,"Кеды",5000,"Кеды на лето"),
                new Product(2,"Блузка",3000,"Блузка для офиса")
            };
        }

        public string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in Products) 
            {
                sb.Append(item.ToString());
            }
            return sb.ToString();
        }
    }
}

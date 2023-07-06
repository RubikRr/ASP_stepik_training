using WomanShop.Interfaces;
using WomanShop.Models;

namespace WomanShop.Storages
{
    public class InMemoryOrdersStorage:IOrdersStorage
    {
        private List<Order> orders=new List<Order>();

        public void Add(Order order)
        {
            orders.Add(order);
        }
    }
}

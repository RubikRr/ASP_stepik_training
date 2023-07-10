using System.Security.Cryptography.X509Certificates;
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
        public List<Order> GetAll() { return orders; }

        public Order TryGetById(Guid id)
        {
            return orders.FirstOrDefault(order => order.Id == id);
        }
        public void UpdateStatus(Guid id, OrderdStatus newStatus)
        {
            var order = this.TryGetById(id);
            if (order != null) 
            {
                order.Status = newStatus;
            }

        }
    }
}

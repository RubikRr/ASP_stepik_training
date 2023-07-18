using System.Security.Cryptography.X509Certificates;
using WomanShop.Interfaces;
using WomanShop.Models;

namespace WomanShop.Storages
{
    public class InMemoryOrdersStorage:IOrdersStorage
    {
        private List<OrderViewModel> orders=new List<OrderViewModel>();

        public void Add(OrderViewModel order)
        {
            orders.Add(order);
        }
        public List<OrderViewModel> GetAll() { return orders; }

        public OrderViewModel TryGetById(Guid id)
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

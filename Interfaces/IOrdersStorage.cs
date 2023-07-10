using WomanShop.Models;

namespace WomanShop.Interfaces
{
    public interface IOrdersStorage
    {
        public void Add(Order order);
        public List<Order> GetAll();
        public Order TryGetById(Guid id);
        public void UpdateStatus(Guid id, OrderdStatus newStatus);
    }
}

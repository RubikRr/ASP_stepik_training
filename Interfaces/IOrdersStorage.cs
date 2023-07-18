using WomanShop.Models;

namespace WomanShop.Interfaces
{
    public interface IOrdersStorage
    {
        public void Add(OrderViewModel order);
        public List<OrderViewModel> GetAll();
        public OrderViewModel TryGetById(Guid id);
        public void UpdateStatus(Guid id, OrderdStatus newStatus);
    }
}

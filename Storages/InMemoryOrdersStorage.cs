using WomanShop.Interfaces;
using WomanShop.Models;

namespace WomanShop.Storages
{
    public class InMemoryOrdersStorage:IOrdersStorage
    {
        private List<Cart> orders=new List<Cart>();

        public void Add(Cart cart)
        {
            orders.Add(cart);
        }
    }
}

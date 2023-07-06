namespace WomanShop.Models
{
    public class Order
    {
        public Guid Id { get; }

        public UserDeliveryInfo DeliveryInfo { get; set; }
        public List<CartItem> Items { get; set; }

        public Order() { }
        public Order(UserDeliveryInfo deliveryInfo,List<CartItem> items)
        {
            Id = new Guid();
            DeliveryInfo= deliveryInfo;
            Items = items;
        }

    }
}

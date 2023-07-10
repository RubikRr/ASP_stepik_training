namespace WomanShop.Models
{
    public enum OrderdStatus 
    {
        Новый=0,
        Подтвержденный=1, 
        Оплаченный=2,
        Доставленный=3,
        Завершенный=4

    }
    public class Order
    {
        private static int orderNumber= 1;

        public Guid Id { get; }
        public int Number { get; set; }
        public UserDeliveryInfo DeliveryInfo { get; set; }
        public List<CartItem> Items { get; set; }
        public OrderdStatus Status { get; set; }
        public decimal Total 
        { 
            get 
            {
                return Items.Sum(x => x.Total);
            }
        }

        public DateTime Date { get; set; }

        public Order() { }
        public Order(UserDeliveryInfo deliveryInfo,List<CartItem> items)
        {
            Id = Guid.NewGuid();
            Status = OrderdStatus.Новый;
            DeliveryInfo= deliveryInfo;
            Items = items;
            Date = DateTime.Now;

            Number = orderNumber;
            orderNumber++;
        }

    }
}

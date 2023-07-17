using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WomanShop.Models
{
    public enum OrderdStatus 
    {
        [Display(Name = "Новый")]
        New = 0,
        [Display(Name = "Подтвержденный")]
        Confirmed = 1,
        [Display(Name = "Оплаченный")]
        Paid = 2,
        [Display(Name = "Доставленный")]
        Delivered = 3,
        [Display(Name = "Завершенный")]
        Complited = 4

    }
    public class Order
    {
        private static int orderNumber= 1;

        public Guid Id { get; }
        public int Number { get; set; }
        public UserDeliveryInfo DeliveryInfo { get; set; }
        public List<CartItemViewModel> Items { get; set; }
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
        public Order(UserDeliveryInfo deliveryInfo,List<CartItemViewModel> items)
        {
            Id = Guid.NewGuid();
            Status = OrderdStatus.New;
            DeliveryInfo= deliveryInfo;
            Items = items;
            Date = DateTime.Now;

            Number = orderNumber;
            orderNumber++;
        }

    }
}

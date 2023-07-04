namespace WomanShop.Models
{
    public class Order
    {
        public Guid Id { get; }

        public string FIO { get; }

        public string Address { get; }
        public string Phone { get; set; }

        public Order(string fIO, string address, string phone)
        {
            Id = new Guid();
            FIO = fIO;
            Address = address;
            Phone = phone;
        }
    }
}

namespace WomanShop.Models
{
    public class CartItem
    {
        public Guid Id { get;}
        public Product Product { get; }
        public int Quantity
        { get; set; } = 0;
        public decimal Total { get { return Product.Cost * Quantity; } }

        

        public CartItem(Product product)
        {
            Id = Guid.NewGuid();
            Product = product;
            Quantity++;
        }


    }
}

namespace WomanShop.Models
{
    public class CartItem
    {
        public Guid Id { get;}
        public Product Product { get; }
        public int Count { get; set; } = 0;
        public decimal Amount { get { return Product.Cost * Count; } }

        

        public CartItem(Product product)
        {
            Id = new Guid();
            Product = product;
            Count++;
        }


    }
}

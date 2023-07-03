namespace WomanShop.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public List<CartItem> Items{ get; set; }

        public Cart( int userId,Product product )
        {
            Id = new Guid();
            UserId = userId;
            Items = new List<CartItem>() {new CartItem(product) };
        }

        public decimal Amount
        {
            get 
            {
                return Items.Sum(cartItem=>cartItem.Amount);
            }
        }

        public void Add(CartItem item)
        {
            Items.Add(item);
        }

        public CartItem TryGetCartItem(int productId)
        {
            return Items.FirstOrDefault(item => item.Product.Id == productId);
        }
    }
}

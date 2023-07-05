namespace WomanShop.Models
{
    public class Favorite
    {
        public Guid Id { get; }
        public int UserId { get; }

        public List<Product>  Products{ get; set; }

        public Favorite( int userId)
        {
            Id = new Guid();
            UserId = userId;
            Products = new List<Product>();
        }
    }
}

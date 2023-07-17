namespace WomanShop.Models
{
    public class Favorite
    {
        public Guid Id { get; }
        public int UserId { get; }

        public List<ProductViewModel>  Products{ get; set; }

        public Favorite( int userId)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Products = new List<ProductViewModel>();
        }
    }
}

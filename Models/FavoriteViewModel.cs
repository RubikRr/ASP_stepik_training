namespace WomanShop.Models
{
    public class FavoriteViewModel
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }

        public List<ProductViewModel>  Products{ get; set; }

    }
}

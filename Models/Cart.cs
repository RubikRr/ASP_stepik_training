namespace WomanShop.Models
{
    public class Cart
    {
        public int UserId { get; }
        public List<Position> Positions{ get; set; }

        public decimal Amount { get; set; }

        public Cart(int userID)
        {
            UserId = userID;
            Positions = new List<Position>();
            Amount = 0;
        }

        public void Add(Product product)
        {
            var postition=Positions.FirstOrDefault(position => position.Product.Id== product.Id);
            if (postition == null)
            {
                Positions.Add(new Position(product, 1));
            }
            else 
            {
                postition.Count++;
            }
            Amount += product.Cost;
        }

        public decimal CalculateAmount() { return Positions.Sum(position => position.Count * position.Product.Cost); }

    }
}

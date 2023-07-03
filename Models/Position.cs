namespace WomanShop.Models
{
    public class Position
    {
        private static int idPositions;
        public int Id { get;}
        public Product Product { get; }
        public int Count { get; set; }

        public Position(Product product, int count)
        {
            Id = idPositions;
            Product = product;
            Count = count;

            idPositions++;
        }

    }
}

namespace WomanShop.Models
{
    public class Product
    {
        static private int counter=0;
        public int Id { get; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get;set;}
        public string ImagePath { get; set; }

        public Product(){}

        public Product(string name, decimal cost, string description, string imagePath)
        {
            Id = counter;
            Name = name;
            Cost = cost;
            Description = description;
            ImagePath = imagePath;

            counter++;
        }
    }
}

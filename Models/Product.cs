namespace WomanShop.Models
{
    public class Product
    {
        static private int counter=0;
        public int Id { get;  }
        public string Name { get; }
        public decimal Cost { get;}
        public string Description { get;}

        public Product( string name, decimal cost, string description)
        {
            Id = counter;
            Name = name;
            Cost = cost;
            Description = description;

            counter++;
        }

        public string ToString()
        {
            return $"Id:{Id}\nНазвание:{Name}\nЦена:{Cost}\nОписание:{Description}\n\n";
        }


    }
}

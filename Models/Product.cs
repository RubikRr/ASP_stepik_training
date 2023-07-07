using System.ComponentModel.DataAnnotations;

namespace WomanShop.Models
{
    public class Product
    {
        static private int counter=0;
        public int Id { get; }
        [Required(ErrorMessage = "Введите название продукта")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Введите цену продукта")]
        [Range(0.0,1000000,ErrorMessage ="Цена варьируется от 0 до 1000000")]
        public decimal Cost { get; set; }
        [Required(ErrorMessage = "Введите описание продукта")]
        [StringLength(10000,ErrorMessage ="Описание до 10000 символов")]
        public string Description { get;set;}
        [Required(ErrorMessage = "Выберете фотографию")]
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

using System.ComponentModel.DataAnnotations;

namespace WomanShop.Models
{
    public class Role
    {
        private static int counter = 0;
        public int Id { get; set; }
        [Required(ErrorMessage ="Введите название роли")]
        [StringLength(50,MinimumLength =1,ErrorMessage ="Минимальная длина 1.Максимальная 50")]
        public string Name { get; set; }

        public Role(){
            Id = counter;
            counter++;
        }

        public Role(string name):this()
        {

            Name = name;
        }
    }
}

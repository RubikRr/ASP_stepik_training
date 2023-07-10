namespace WomanShop.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public Registration Registration { get; set; }

        public User(Registration registration)
        {
            Id=Guid.NewGuid();
            Registration = registration;
        }
    }   
}

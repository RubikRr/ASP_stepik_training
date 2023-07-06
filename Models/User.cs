namespace WomanShop.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email{ get; set; }

        public string Password { get; set; }
        public bool Remember { get; set; }
        public User() { }

        public User(int id, string email, string password, bool remember)
        {
            Id = 0;
            Email = email;
            Password = password;
            Remember = remember;
        }
    }
}

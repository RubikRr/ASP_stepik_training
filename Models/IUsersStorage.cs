namespace WomanShop.Models
{
    public interface IUsersStorage
    {
        public void Add(User user);
        public User TryGetUserById(Guid id);

        public User TryGetUserByEmail(string email);

        public bool IsCorrectPassword(Login login);
        public void Remove(Guid userId);
        public void Update(User userId);
        public void UpdatePassword(User userId, string password, string confirmPassword);

        public List<User> GetAll();
    }
}

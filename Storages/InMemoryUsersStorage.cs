using WomanShop.Interfaces;
using WomanShop.Models;

namespace WomanShop.Storages
{
    public class InMemoryUsersStorage:IUsersStorage
    {
        public List<User> users=new List<User>();

        public void Add(User user)
        {
            users.Add(user);
        }

        public User TryGetUserById(Guid id)
        {
            return users.FirstOrDefault(user => user.Id == id);
        }
        public User TryGetUserByEmail(string email)
        {
            return users?.FirstOrDefault(user => user.Registration.Email == email)??null;
        }

        public bool IsCorrectPassword(Login login)
        {
            var user=TryGetUserByEmail(login.Email);
            return user != null && user.Registration.Password == login.Password;
        }
    }
}

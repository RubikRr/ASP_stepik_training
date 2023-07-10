using WomanShop.Interfaces;
using WomanShop.Models;

namespace WomanShop.Storages
{
    public class InMemoryUsersStorage:IUsersStorage
    {
        public List<User> users=new List<User>() 
        { 
            new User("vova.chakalov.2003@yandex.ru","1"),
            new User("alina.mamsurova.2004.ru","2")
        };

        public void Add(User user)
        {
            users.Add(user);
        }
        public List<User> GetAll()
        {
            return users;
        }
        public User TryGetUserById(Guid id)
        {
            return users.FirstOrDefault(user => user.Id == id);
        }
        public User TryGetUserByEmail(string email)
        {
            return users?.FirstOrDefault(user => user.Email == email)??null;
        }

        public bool IsCorrectPassword(Login login)
        {
            var user=TryGetUserByEmail(login.Email);
            return user != null && user.Password == login.Password;
        }
    }
}

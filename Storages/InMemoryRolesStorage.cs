using WomanShop.Interfaces;
using WomanShop.Models;

namespace WomanShop.Storages
{
    public class InMemoryRolesStorage : IRolesStorage
    {
        private List<Role> roles = new List<Role>()
        {
            new Role("Админ"),
            new Role("Пользователь")
        };

        public List<Role> GetAll()
        {
            return roles;
        }
        public void Add(Role role)
        {
            roles.Add(role);
        }
        public bool IsInStorage(Role role)
        {
            return roles.Any(roleInStorage=>roleInStorage.Name==role.Name);
        }
        public void Remove(int roleId)
        { 
            var role = roles.FirstOrDefault(role=>role.Id==roleId);
            if (role == null)
                return;
            roles.Remove(role);
        }
    }
}

using System.Data;
using WomanShop.Models;

namespace WomanShop.Interfaces
{
    public interface IRolesStorage
    {
        public List<Role> GetAll();
        public void Add(Role role);
        public void Remove(int id);
        public bool IsInStorage(Role role);
    }
}

using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IUserRepository
    {
        Task<User> GetByIdUser(Guid id);
        Task<IEnumerable<User>> GetAllUser();
        Task AddUser(User user);
        Task UpdateUser(User user);
        Task RemoveUser(User user);
    }
}

using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;
        UserRepository _res;

        public UserService(AppDbContext context)
        {
            _context = context;
            _res = new UserRepository(context);
        }

        public async Task<User> GetByIdUser(Guid id)
        {
            return await _res.GetByIdUser(id);
        }

        //Getall
        public async Task<IEnumerable<User>> GetAllUser()
        {
            return await _res.GetAllUser();
        }

        //add
        public async Task AddUser(User user)
        {
            await _res.AddUser(user);
        }

        //update
        public async Task UpdateUser(User user)
        {
            await _res.UpdateUser(user);
        }

        //Remove

        public async Task RemoveUser(User user)
        {
            await _res.RemoveUser(user);
        }

        //sử dụng await với các phương thức bất đồng bộ 
    }
}

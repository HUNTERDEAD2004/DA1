using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class IphoneService
    {
        private readonly AppDbContext _context;
        IphoneRepository _res;

        public IphoneService(AppDbContext context)
        {
            _context = context;
            _res = new IphoneRepository(context);
        }

        public async Task<Iphone> GetByIdIphone(Guid id) // sử dụng async để đánh dấu là phương thức bất đồng bộ thì mới dùng được await
        {
            return await _res.GetByIdIphone(id);
        }

        //Getall
        public async Task<IEnumerable<Iphone>> GetAllIphone()
        {
            return await _res.GetAllIphone();
        }

        //add
        public async Task AddIphone(Iphone iphone)
        {
            await _res.AddIphone(iphone);
        }

        //update
        public async Task UpdateIphone(Iphone iphone)
        {
            await _res.UpdateIphone(iphone);
        }

        //Remove

        public async Task RemoveIphone(Iphone iphone)
        {
            await _res.RemoveIphone(iphone);
        }
    }
}

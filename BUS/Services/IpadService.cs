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
    public class IpadService
    {
        private readonly AppDbContext _context;
        IpadRepository _res;

        public IpadService(AppDbContext context)
        {
            _context = context;
            _res = new IpadRepository(context);
        }

        public async Task AddIpad(Ipad ipad)
        {
            await _res.AddIpad(ipad);
        }

        public async Task<IEnumerable<Ipad>> GetAllIpad()
        {
            return await _res.GetAllIpad();
        }

        public async Task<Ipad> GetByIdIpad(Guid id)
        {
            return await _res.GetByIdIpad(id);
        }

        public async Task RemoveIpad(Ipad ipad)
        {
            await _res.RemoveIpad(ipad);
        }

        public async Task UpdateIpad(Ipad ipad)
        {
            await _res.UpdateIpad(ipad);
        }
    }
}

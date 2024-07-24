using DAL.IRepository;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class IpadRepository : IIpadRepository
    {
        private readonly AppDbContext _context;
        public IpadRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddIpad(Ipad ipad)
        {
            _context.Ipads.Add(ipad);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Ipad>> GetAllIpad()
        {
            return await _context.Ipads.ToListAsync(); // đoạn này lỗi thì thêm using Microsoft.EntityFrameworkCore;
        }

        public async Task<Ipad> GetByIdIpad(Guid id)
        {
            return await _context.Ipads.FindAsync(id);
        }

        public async Task RemoveIpad(Ipad ipad)
        {
            _context.Ipads.Remove(ipad);
            await _context.SaveChangesAsync();  
        }

        public async Task UpdateIpad(Ipad ipad)
        {
            _context.Ipads.Update(ipad);
            await _context.SaveChangesAsync();
        }
    }
}

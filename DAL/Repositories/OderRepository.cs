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
    public class OderRepository : IOderRepository
    {
        private readonly AppDbContext _context;
        public OderRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddOder(Oder oder) { 
            _context.Oders.Add(oder);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Oder>> GetAllOder()
        {
            return await _context.Oders.ToListAsync(); // đoạn này lỗi thì thêm using Microsoft.EntityFrameworkCore;
        }
      

        public async Task<Oder> GetByIdOder(Guid id)
        {
            return await _context.Oders.FindAsync(id);
        }

        public async Task RemoveOder(Oder oder)
        {
            _context.Oders.Remove(oder);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateOder(Oder oder)
        {
            _context.Oders.Update(oder);
            await _context.SaveChangesAsync();
        }
    }
}

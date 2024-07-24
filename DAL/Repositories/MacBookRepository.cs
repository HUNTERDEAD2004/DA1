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
    public class MacBookRepository : IMacBookRepository
    {
        private readonly AppDbContext _context;
        public MacBookRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddMacBook(MacBook macbook)
        {
            _context.MacBooks.Add(macbook);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<MacBook>> GetAllMacBook()
        {
             return await _context.MacBooks.ToListAsync(); // đoạn này lỗi thì thêm using Microsoft.EntityFrameworkCore;
        }

        public async Task<MacBook> GetByIdMacBook(Guid id)
        {
            return await _context.MacBooks.FindAsync(id);
        }

        public async Task RemoveMacBook(MacBook macbook)
        {
            _context.MacBooks.Remove(macbook);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMacBook(MacBook macbook)
        {
            _context.MacBooks.Update(macbook);
            await _context.SaveChangesAsync();
        }
    }
}

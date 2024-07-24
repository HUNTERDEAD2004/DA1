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
    public class AppWatchRepository : IAppleWatchRepository
    {
        private readonly AppDbContext _context;
        public AppWatchRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAppleWatch(AppleWatch appleWatch)
        {
            _context.AppleWatches.Add(appleWatch);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<AppleWatch>> GetAllAppleWatch()
        {
            return await _context.AppleWatches.ToListAsync(); // đoạn này lỗi thì thêm using Microsoft.EntityFrameworkCore;
        }

        public async Task<AppleWatch> GetByIdAppleWatch(Guid id)
        {
            return await _context.AppleWatches.FindAsync(id);
        }

        public async Task RemoveAppleWatch(AppleWatch appleWatch)
        {
            _context.AppleWatches.Remove(appleWatch);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAppleWatch(AppleWatch appleWatch)
        {
            _context.AppleWatches.Update(appleWatch);
            await _context.SaveChangesAsync();
        }
    }
}

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
    public class AppWatchService
    {
        private readonly AppDbContext _context;
        AppWatchRepository _res;

        public AppWatchService(AppDbContext context)
        {
            _context = context;
            _res = new AppWatchRepository(context);
        }

        public async Task AddAppleWatch(AppleWatch appleWatch)
        {
            await _res.AddAppleWatch(appleWatch);
        }

        public async Task<IEnumerable<AppleWatch>> GetAllAppleWatch()
        {
            return await _res.GetAllAppleWatch();
        }

        public async Task<AppleWatch> GetByIdAppleWatch(Guid id)
        {
            return await _res.GetByIdAppleWatch(id);
        }

        public async Task RemoveAppleWatch(AppleWatch appleWatch)
        {
            await _res.RemoveAppleWatch(appleWatch);
        }

        public async Task UpdateAppleWatch(AppleWatch appleWatch)
        {
            await _res.UpdateAppleWatch(appleWatch);
        }
    }
}

using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IAppleWatchRepository
    {
        Task<AppleWatch> GetByIdAppleWatch(Guid id);
        Task<IEnumerable<AppleWatch>> GetAllAppleWatch();
        Task AddAppleWatch(AppleWatch appleWatch);
        Task UpdateAppleWatch(AppleWatch appleWatch);
        Task RemoveAppleWatch(AppleWatch appleWatch);
    }
}

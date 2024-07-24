using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL.IRepository
{
    public interface IAccessoryRepository
    {
        Task<Accessory> GetByIdAccessory(Guid id);
        Task<IEnumerable<Accessory>> GetAllAccessoryc();
        Task AddAccessoryc(Accessory accessory);
        Task UpdateAccessory(Accessory accessory);
        Task RemoveAccessory(Accessory accessory);
        
    }
}

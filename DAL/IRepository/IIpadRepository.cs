using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IIpadRepository
    {
        Task<Ipad> GetByIdIpad(Guid id);
        Task<IEnumerable<Ipad>> GetAllIpad();
        Task AddIpad(Ipad ipad);
        Task UpdateIpad(Ipad ipad);
        Task RemoveIpad(Ipad ipad);
    }
}

using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IMacBookRepository
    {
        Task<MacBook> GetByIdMacBook(Guid id);
        Task<IEnumerable<MacBook>> GetAllMacBook();
        Task AddMacBook(MacBook macbook);
        Task UpdateMacBook(MacBook macbook);
        Task RemoveMacBook(MacBook macbook);
    }
}

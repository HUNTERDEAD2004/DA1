using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
     public interface IOderRepository
    {
        Task<Oder> GetByIdOder(Guid id);
        Task<IEnumerable<Oder>> GetAllOder();
        Task AddOder(Oder oder);
        Task UpdateOder(Oder oder);
        Task RemoveOder(Oder oder);
    }
}

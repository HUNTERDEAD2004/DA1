using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IWarrantyRepository
    {
        Task<Warranty> GetByIdWarranty(Guid id);
        Task<IEnumerable<Warranty>> GetAllWarranty();
        Task AddWarranty(Warranty warranty);
        Task UpdateWarranty(Warranty warranty);
        Task RemoveWarranty(Warranty warranty);
    }
}

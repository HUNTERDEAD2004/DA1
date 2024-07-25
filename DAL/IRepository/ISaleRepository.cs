using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface ISaleRepository
    {
        Task<Sale> GetByIdSale(Guid id);
        Task<IEnumerable<Sale>> GetAllSale();
        Task AddSale(Sale sale);
        Task UpdateSale(Sale sale);
        Task RemoveSale(Sale sale);
    }
}

using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IImacRepository
    {
        Task<Imac> GetByIdImac(Guid id);
        Task<IEnumerable<Imac>> GetAllImac();
        Task AddImac(Imac imac);
        Task UpdateImac(Imac imac);
        Task RemoveImac(Imac imac);
    }
}

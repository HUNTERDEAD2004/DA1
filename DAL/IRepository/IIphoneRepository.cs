using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IIphoneRepository
    {
        Task<Iphone> GetByIdIphone(Guid id);
        Task<IEnumerable<Iphone>> GetAllIphone();
        Task AddIphone(Iphone iphone);
        Task UpdateIphone(Iphone iphone);
        Task RemoveIphone(Iphone Iphone);

    }
}

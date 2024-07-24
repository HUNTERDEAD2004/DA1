using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IOderDetailRepository
    {
        Task<OderDetail> GetByIdOderDetail(Guid id);
        Task<IEnumerable<OderDetail>> GetAllOderDetail();
        Task AddOderDetail(OderDetail oderDetail);
        Task UpdateOderDetail(OderDetail oderDetail);
        Task RemoveOderDetail(OderDetail oderDetail);
    }
}

using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IAirPodRepository
    {
        Task<AirPod> GetByIdAirPod(Guid id);
        Task<IEnumerable<AirPod>> GetAllAirPod();
        Task AddAirPod(AirPod airPod);
        Task UpdateAirPod(AirPod airPod);
        Task RemoveAirPod(AirPod airPod);
        
    }
}

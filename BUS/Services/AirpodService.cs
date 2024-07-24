using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class AirpodService
    {
        private readonly AppDbContext _context;
        AirPodRepository _res;

        public AirpodService(AppDbContext context)
        {
            _context = context;
            _res = new AirPodRepository(context);
        }

        public async Task<AirPod> GetByIdAirPod(Guid id)
        {
            return await _res.GetByIdAirPod(id); // Sử dụng FindAsync để tìm
        }

        //Getall
        public async Task<IEnumerable<AirPod>> GetAllAirPod()
        {
            return await _res.GetAllAirPod(); // đoạn này lỗi thì thêm using Microsoft.EntityFrameworkCore;
        }

        //add
        public async Task AddAirPod(AirPod airPod)
        {
            await _res.AddAirPod(airPod);
        }

        //update
        public async Task UpdateAirPod(AirPod airPod)
        {
            await _res.UpdateAirPod(airPod);
        }

        //Remove

        public async Task RemoveAirPod(AirPod airPod)
        {
            await _res.RemoveAirPod(airPod);
        }
    }
}

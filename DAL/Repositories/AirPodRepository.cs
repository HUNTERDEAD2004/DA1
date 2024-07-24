using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class AirPodRepository : IAirPodRepository
    {
        private readonly AppDbContext _context;

        public AirPodRepository(AppDbContext context)
        {
            _context = context;
        }

        //getByid
        public async Task<AirPod> GetByIdAirPod(Guid id)
        {
            return await _context.AirPods.FindAsync(id); // Sử dụng FindAsync để tìm
        }

        //Getall
        public async Task<IEnumerable<AirPod>> GetAllAirPod()
        {
            return await _context.AirPods.ToListAsync(); // đoạn này lỗi thì thêm using Microsoft.EntityFrameworkCore;
        }

        //add
        public async Task AddAirPod(AirPod airPod)
        {
            await _context.AirPods.AddAsync(airPod);
            await _context.SaveChangesAsync();
        }

        //update
        public async Task UpdateAirPod(AirPod airPod)
        {
            _context.AirPods.Update(airPod);
            await _context.SaveChangesAsync();
        }

        //Remove

        public async Task RemoveAirPod(AirPod airPod)
        {
            _context.AirPods.Remove(airPod);
            await _context.SaveChangesAsync();
        }
        //sử dụng await với các phương thức bất đồng bộ 
    }
}

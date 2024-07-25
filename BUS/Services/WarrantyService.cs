using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class WarrantyService
    {
        private readonly AppDbContext _context;
        WarrantyRepository _res;

        public WarrantyService(AppDbContext context)
        {
            _context = context;
            _res = new WarrantyRepository(context);
        }

        public async Task<Warranty> GetByIdWarranty(Guid id)
        {
            return await _res.GetByIdWarranty(id);
        }

        //Getall
        public async Task<IEnumerable<Warranty>> GetAllWarranty()
        {
            return await _res.GetAllWarranty();
        }

        //add
        public async Task AddWarranty(Warranty warranty)
        {
            await _res.AddWarranty(warranty);
        }

        //update
        public async Task UpdateWarranty(Warranty warranty)
        {
            await _res.UpdateWarranty(warranty);
        }

        //Remove

        public async Task RemoveWarranty(Warranty warranty)
        {
            await _res.RemoveWarranty(warranty);
        }

        //sử dụng await với các phương thức bất đồng bộ 
    }
}

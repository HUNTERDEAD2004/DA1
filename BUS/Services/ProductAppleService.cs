using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ProductAppleService
    {
        private readonly AppDbContext _context;
        ProductAppleRepository _res;

        public ProductAppleService(AppDbContext context)
        {
            _context = context;
            _res = new ProductAppleRepository(context);
        }

        public async Task<Warranty> GetByIdProductApple(Guid id)
        {
            return await _res.GetByIdProductApple(id);
        }

        //Getall
        public async Task<IEnumerable<Warranty>> GetAllWarranty()
        {
            return await _res.GetAllWarranty();
        }

        //add
        public async Task AddProductApplec(Warranty warranty)
        {
            await _res.AddProductApple(warranty);
        }

        //update
        public async Task UpdateProductApple(Warranty warranty)
        {
            await _res.UpdateProductApple(warranty);
        }

        //Remove

        public async Task RemoveProductApple(Warranty warranty)
        {
            await _res.RemoveProductApple(warranty);
        }

        //sử dụng await với các phương thức bất đồng bộ 
    }
}

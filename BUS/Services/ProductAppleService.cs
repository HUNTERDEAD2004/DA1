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

        public async Task<ProductApple> GetByIdProductApple(Guid id)
        {
            return await _res.GetByIdProductApple(id);
        }

        //Getall
        public async Task<IEnumerable<ProductApple>> GetAllProductApple()
        {
            return await _res.GetAllProductApple();
        }

        //add
        public async Task AddProductApple(ProductApple productApple)
        {
            await _res.AddProductApple(productApple);
        }

        //update
        public async Task UpdateProductApple(ProductApple productApple)
        {
            await _res.UpdateProductApple(productApple);
        }

        //Remove

        public async Task RemoveProductApple(ProductApple productApple)
        {
            await _res.RemoveProductApple(productApple);
        }

        //sử dụng await với các phương thức bất đồng bộ 
    }
}

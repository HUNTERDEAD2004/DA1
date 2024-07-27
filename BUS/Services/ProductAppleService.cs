using DAL.IRepository;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProductAppleRepository : IProductAppleRepository
    {
        private readonly AppDbContext _context;

        public ProductAppleRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddProductApple(ProductApple productApple)
        {
            _context.productApples.Add(productApple);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductApple>> GetAllProductApple()
        {
            return await _context.productApples.ToListAsync(); // đoạn này lỗi thì thêm using Microsoft.EntityFrameworkCore;
        }

        public async Task<ProductApple> GetByIdProductApple(Guid id)
        {
            return await _context.productApples.FindAsync(id);
        }

        public async Task RemoveProductApple(ProductApple productApple)
        {
            _context.productApples.Remove(productApple);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductApple(ProductApple productApple)
        {
            _context.productApples.Update(productApple);
            await _context.SaveChangesAsync();
        }
    }
}

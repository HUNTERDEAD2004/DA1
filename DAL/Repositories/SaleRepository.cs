using DAL.IRepository;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly AppDbContext _context;

        public SaleRepository(AppDbContext context)
        {
            _context = context;
        }

        //getByid
        public async Task<Sale> GetByIdSale(Guid id) // sử dụng async để đánh dấu là phương thức bất đồng bộ thì mới dùng được await
        {
            return await _context.sales.FindAsync(id); // Sử dụng FindAsync để tìm
        }

        //Getall
        public async Task<IEnumerable<Sale>> GetAllSale()
        {
            return await _context.sales.ToListAsync(); // đoạn này lỗi thì thêm using Microsoft.EntityFrameworkCore;
        }

        //add
        public async Task AddSale(Sale sale)
        {
            await _context.sales.AddAsync(sale);
            await _context.SaveChangesAsync();
        }

        //update
        public async Task UpdateSale(Sale sale)
        {
            _context.sales.Update(sale);
            await _context.SaveChangesAsync();
        }

        //Remove

        public async Task RemoveSale(Sale sale)
        {
            _context.sales.Remove(sale);
            await _context.SaveChangesAsync();
        }

        //sử dụng await với các phương thức bất đồng bộ 
    }
}

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
    public class WarrantyRepository : IWarrantyRepository
    {
        private readonly AppDbContext _context;

        public WarrantyRepository(AppDbContext context)
        {
            _context = context;
        }

        //getByid
        public async Task<Warranty> GetByIdWarranty(Guid id) // sử dụng async để đánh dấu là phương thức bất đồng bộ thì mới dùng được await
        {
            return await _context.warranties.FindAsync(id); // Sử dụng FindAsync để tìm
        }

        //Getall
        public async Task<IEnumerable<Warranty>> GetAllWarranty()
        {
            return await _context.warranties.ToListAsync(); // đoạn này lỗi thì thêm using Microsoft.EntityFrameworkCore;
        }

        //add
        public async Task AddWarranty(Warranty warranty)
        {
            await _context.warranties.AddAsync(warranty);
            await _context.SaveChangesAsync();
        }

        //update
        public async Task UpdateWarranty(Warranty warranty)
        {
            _context.warranties.Update(warranty);
            await _context.SaveChangesAsync();
        }

        //Remove

        public async Task RemoveWarranty(Warranty warranty)
        {
            _context.warranties.Remove(warranty);
            await _context.SaveChangesAsync();
        }

        //sử dụng await với các phương thức bất đồng bộ 
    }
}

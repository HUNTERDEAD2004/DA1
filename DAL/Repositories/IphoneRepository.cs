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
    public class IphoneRepository : IIphoneRepository
    {
        private readonly AppDbContext _context;

        public IphoneRepository(AppDbContext context)
        {
            _context = context;
        }

        //getByid
        public async Task<Iphone> GetByIdIphone(Guid id) // sử dụng async để đánh dấu là phương thức bất đồng bộ thì mới dùng được await
        {
            return await _context.Iphones.FindAsync(id); // Sử dụng FindAsync để tìm
        }

        //Getall
        public async Task<IEnumerable<Iphone>> GetAllIphone()
        {
            return await _context.Iphones.ToListAsync(); // đoạn này lỗi thì thêm using Microsoft.EntityFrameworkCore;
        }

        //add
        public async Task AddIphone(Iphone iphone)
        {
            await _context.Iphones.AddAsync(iphone);
            await _context.SaveChangesAsync();
        }

        //update
        public async Task UpdateIphone(Iphone iphone)
        {
            _context.Iphones.Update(iphone);
            await _context.SaveChangesAsync();
        }

        //Remove

        public async Task RemoveIphone(Iphone iphone)
        {
            _context.Iphones.Remove(iphone);
            await _context.SaveChangesAsync();
        }

        //sử dụng await với các phương thức bất đồng bộ 

    }
}

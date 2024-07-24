using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.IRepository;

namespace DAL.Repositories
{
    public class AccessoryRepository : IAccessoryRepository
    {
        private readonly AppDbContext _context;

        public AccessoryRepository(AppDbContext context)
        {
            _context = context;
        }

       //getByid
        public async Task<Accessory> GetByIdAccessory(Guid id) // sử dụng async để đánh dấu là phương thức bất đồng bộ thì mới dùng được await
        {
            return await _context.accessories.FindAsync(id); // Sử dụng FindAsync để tìm
        }

        //Getall
        public async Task<IEnumerable<Accessory>> GetAllAccessoryc()
        {
            return await _context.accessories.ToListAsync(); // đoạn này lỗi thì thêm using Microsoft.EntityFrameworkCore;
        }

        //add
        public async Task AddAccessoryc(Accessory accessory)
        {
            await _context.accessories.AddAsync(accessory);
            await _context.SaveChangesAsync();
        }

        //update
        public async Task UpdateAccessory(Accessory accessory)
        {
            _context.accessories.Update(accessory);
            await _context.SaveChangesAsync();
        }

        //Remove

        public async Task RemoveAccessory(Accessory accessory)
        {
            _context.accessories.Remove(accessory);
            await _context.SaveChangesAsync();
        }

        //sử dụng await với các phương thức bất đồng bộ 
    }
}

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
    public class ImacRepository : IImacRepository
    {
        private readonly AppDbContext _context;
        public ImacRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddImac(Imac imac)
        {
            _context.Imacs.Add(imac);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Imac>> GetAllImac()
        {
            return await _context.Imacs.ToListAsync(); // đoạn này lỗi thì thêm using Microsoft.EntityFrameworkCore;
        }

        public async Task<Imac> GetByIdImac(Guid id)
        {
            return await _context.Imacs.FindAsync(id);
        }

        public async Task RemoveImac(Imac imac)
        {
            _context.Imacs.Remove(imac);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateImac(Imac imac)
        {
            _context.Imacs.Update(imac);
            await _context.SaveChangesAsync();
        }
    }
}

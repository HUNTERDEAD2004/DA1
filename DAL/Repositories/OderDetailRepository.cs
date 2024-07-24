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
    public class OderDetailRepository : IOderDetailRepository
    {
        private readonly AppDbContext _context;
        public OderDetailRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddOderDetail(OderDetail oderDetail)
        {
            _context.oderDetails.Add(oderDetail);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<OderDetail>> GetAllOderDetail()
        {
            return await _context.oderDetails.ToListAsync(); // đoạn này lỗi thì thêm using Microsoft.EntityFrameworkCore;
        }

        public async Task<OderDetail> GetByIdOderDetail(Guid id)
        {
            return await _context.oderDetails.FindAsync(id);
        }

        public async Task RemoveOderDetail(OderDetail oderDetail)
        {
            _context.oderDetails.Remove(oderDetail);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateOderDetail(OderDetail oderDetail)
        {
            _context.oderDetails.Update(oderDetail);
            await _context.SaveChangesAsync();
        }
    }
}

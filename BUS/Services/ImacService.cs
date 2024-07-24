using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ImacService
    {
        private readonly AppDbContext _context;
        ImacRepository _res;

        public ImacService(AppDbContext context)
        {
            _context = context;
            _res = new ImacRepository(context);
        }

        public async Task AddImac(Imac imac)
        {
            await _res.AddImac(imac);
        }

        public async Task<IEnumerable<Imac>> GetAllImac()
        {
            return await _res.GetAllImac();
        }

        public async Task<Imac> GetByIdImac(Guid id)
        {
            return await _res.GetByIdImac(id);
        }

        public async Task RemoveImac(Imac imac)
        {
            await _res.RemoveImac(imac);
        }

        public async Task UpdateImac(Imac imac)
        {
            await _res.UpdateImac(imac);
        }
    }
}

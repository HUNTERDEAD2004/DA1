using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class OderService
    {
        private readonly AppDbContext _context;
        OderRepository _res;

        public OderService(AppDbContext context)
        {
            _context = context;
            _res = new OderRepository(context);
        }

        public async Task<Oder> GetByIdOder(Guid id)
        {
            return await _res.GetByIdOder(id);
        }

        //Getall
        public async Task<IEnumerable<Oder>> GetAllOder()
        {
            return await _res.GetAllOder();
        }

        //add
        public async Task AddOder(Oder oder)
        {
            await _res.AddOder(oder);
        }

        //update
        public async Task UpdateOder(Oder oder)
        {
            await _res.UpdateOder(oder);
        }

        //Remove

        public async Task RemoveOder(Oder oder)
        {
            await _res.RemoveOder(oder);
        }

        //sử dụng await với các phương thức bất đồng bộ 
    }
}

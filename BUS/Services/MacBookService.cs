using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class MacBookService
    {
        private readonly AppDbContext _context;
        MacBookRepository _res;

        public MacBookService(AppDbContext context)
        {
            _context = context;
            _res = new MacBookRepository(context);
        }

        public async Task<MacBook> GetByIdAccessory(Guid id)
        {
            return await _res.GetByIdMacBook(id);
        }

        //Getall
        public async Task<IEnumerable<MacBook>> GetAllMacBook()
        {
            return await _res.GetAllMacBook();
        }

        //add
        public async Task AddMacBook(MacBook macBook)
        {
            await _res.AddMacBook(macBook);
        }

        //update
        public async Task UpdateMacBook(MacBook macBook)
        {
            await _res.AddMacBook(macBook);
        }

        //Remove

        public async Task RemoveMacBook(MacBook macBook)
        {
            await _res.AddMacBook(macBook);
        }

        //sử dụng await với các phương thức bất đồng bộ 
    }
}

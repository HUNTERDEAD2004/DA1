using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class SaleService
    {
        private readonly AppDbContext _context;
        SaleRepository _res;

        public SaleService(AppDbContext context)
        {
            _context = context;
            _res = new SaleRepository(context);
        }

        public async Task<Sale> GetByIdSale(Guid id)
        {
            return await _res.GetByIdSale(id);
        }

        //Getall
        public async Task<IEnumerable<Sale>> GetAllSale()
        {
            return await _res.GetAllSale();
        }

        //add
        public async Task AddSale(Sale sale)
        {
            await _res.AddSale(sale);
        }

        //update
        public async Task UpdateSale(Sale sale)
        {
            await _res.UpdateSale(sale);
        }

        //Remove

        public async Task RemoveSale(Sale sale)
        {
            await _res.RemoveSale(sale);
        }

        //sử dụng await với các phương thức bất đồng bộ 
    }
}

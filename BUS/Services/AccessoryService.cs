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
    public class AccessoryService
    {
        private readonly AppDbContext _context;
        AccessoryRepository _res;

        public AccessoryService(AppDbContext context)
        {
            _context = context;
            _res = new AccessoryRepository(context);
        }

        public async Task<Accessory> GetByIdAccessory(Guid id) 
        {
            return await _res.GetByIdAccessory(id); 
        }

        //Getall
        public async Task<IEnumerable<Accessory>> GetAllAccessoryc()
        {
            return await _res.GetAllAccessoryc(); 
        }

        //add
        public async Task AddAccessoryc(Accessory accessory)
        {
            await _res.AddAccessoryc(accessory);
        }

        //update
        public async Task UpdateAccessory(Accessory accessory)
        {
            await _res.UpdateAccessory(accessory);
        }

        //Remove

        public async Task RemoveAccessory(Accessory accessory)
        {
            await _res.RemoveAccessory(accessory);
        }

        //sử dụng await với các phương thức bất đồng bộ 
    }
}

using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class OderDetailService
    {
        private readonly AppDbContext _context;
        OderDetailRepository _res;

        public OderDetailService(AppDbContext context)
        {
            _context = context;
            _res = new OderDetailRepository(context);
        }

        public async Task<OderDetail> GetByIdOderDetail(Guid id)
        {
            return await _res.GetByIdOderDetail(id);
        }

        //Getall
        public async Task<IEnumerable<OderDetail>> GetAllOderDetail()
        {
            return await _res.GetAllOderDetail();
        }

        //add
        public async Task AddOderDetail(OderDetail oderDetail)
        {
            await _res.AddOderDetail(oderDetail);
        }

        //update
        public async Task UpdateOderDetail(OderDetail oderDetail)
        {
            await _res.UpdateOderDetail(oderDetail);
        }

        //Remove

        public async Task RemoveOderDetail(OderDetail oderDetail)
        {
            await _res.RemoveOderDetail(oderDetail);
        }

        //sử dụng await với các phương thức bất đồng bộ 
    }
}

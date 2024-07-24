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
    public class CustomerService
    {
        private readonly AppDbContext _context;
        CustomerRepository _res;

        public CustomerService(AppDbContext context)
        {
            _context = context;
            _res = new CustomerRepository(context);
        }

        public async Task<IEnumerable<Customer>> GetAllCustomer()
        {
            return await _res.GetAllCustomer();
        }

        public async Task<Customer> GetByIdCustomer(Guid id)
        {
            return await _res.GetByIdCustomer(id);
        }

        public async Task AddCustomer(Customer customer)
        {
            await _res.AddCustomer(customer);
        }

        public async Task RemoveCustomer(Customer customer)
        {
            await _res.RemoveCustomer(customer);
        }

        public async Task UpdateCustomer(Customer customer)
        {
            await _res.UpdateCustomer(customer);
        }
    }
}

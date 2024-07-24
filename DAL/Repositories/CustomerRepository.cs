using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CustomerRepository
    {
        private readonly AppDbContext _context;
        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddCustomer(Customer customer)
        {
            _context.customers.Add(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllCustomer()
        {
            return await _context.customers.ToListAsync(); // đoạn này lỗi thì thêm using Microsoft.EntityFrameworkCore;
        }

        public async Task<Customer> GetByIdCustomer(Guid id)
        {
            return await _context.customers.FindAsync(id);
        }

        public async Task RemoveCustomer(Customer customer)
        {
            _context.customers.Remove(customer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCustomer(Customer customer)
        {
            _context.customers.Update(customer);
            await _context.SaveChangesAsync();
        }
    }
}

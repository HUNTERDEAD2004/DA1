using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface ICustomerRepository
    {
        Task<Customer> GetByIdCustomer(Guid id);
        Task<IEnumerable<Customer>> GetAllCustomer();
        Task AddCustomer(Customer customer);
        Task UpdateCustomer(Customer customer);
        Task RemoveCustomer(Customer customer);
    }
}

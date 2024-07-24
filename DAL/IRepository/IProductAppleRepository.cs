using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IProductAppleRepository
    {
        Task<ProductApple> GetByIdProductApple(Guid id);
        Task<IEnumerable<ProductApple>> GetAllProductApple();
        Task AddProductApple(ProductApple productApple);
        Task UpdateProductApple(ProductApple productApple);
        Task RemoveProductApple(ProductApple productApple);
    }
}

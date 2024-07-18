using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ProductVoucher
    {
        public Guid ProductVoucherID { get; set; }
        public Guid ProductApple { get; set; }
        public Guid VoucherID { get; set; } 
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ProductVoucher
    {
        [Key]
        public Guid ProductVoucherID { get; set; }
        public Guid ProductId { get; set; }
        public Guid VoucherID { get; set; } 
        public virtual ProductApple Product {  get; set; }  
        public virtual Voucher Voucher { get; set; }    
    }
}

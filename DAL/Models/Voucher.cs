using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Voucher
    {
        [Key]
        public Guid VoucherID { get; set; }
        public DateTime CreateAt { get; set; }  
        public DateTime UpdateAt { get; set; }
        public DateTime EndTime { get; set; }
        public string Percent {  get; set; }
        public string VoucherCode { get; set;}
        public virtual ICollection<ProductVoucher> ProductVouchers { get; set;}
    }
}

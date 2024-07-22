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
        public string? CreateBy { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime EndTime { get; set; }
        public int Percent {  get; set; }
        public string? VoucherCode { get; set;}
        public virtual ICollection<ProductVoucher> ProductVouchers { get; set;} = new List<ProductVoucher>();
    }
}

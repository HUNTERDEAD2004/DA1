using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Voucher
    {
        public Guid IDVoucher { get; set; }
        public decimal Discount { get; set; }     
        public DateTime Expired_Date { get; set; }
        public decimal Minium_Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }

    }
}

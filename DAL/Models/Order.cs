using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class Order
    {
        [Key]
        public Guid OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        [ForeignKey("CustomerID")]
        public Guid CustomerID { get; set; }
        [ForeignKey("AccountID")]
<<<<<<< HEAD
        public Guid AccountID { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Price { get; set; }
=======
        public Guid? AccountID { get; set; }
        public Guid? IDVoucher { get; set; }
        public Guid ReportID { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? Price { get; set; }
        public int? Status { get; set; }
>>>>>>> An-DBNew
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Status { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Account Account { get; set; }
<<<<<<< HEAD

=======
        public virtual Voucher Voucher { get; set; }
        public Report Report { get; set; }
        public ICollection<CancelledOrder> CancelledOrders { get; set; }
>>>>>>> An-DBNew
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}

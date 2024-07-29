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
        public Guid AccountID { get; set; }
        public Guid ProductID { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Status { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Account Account { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

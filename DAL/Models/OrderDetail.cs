using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppData.Models
{
    public class OrderDetail
    {
        [Key]
        public Guid OrderDetailID { get; set; }

        public Guid OrderID { get; set; }

        public Guid IMEI { get; set; }

        [StringLength(255)]
        public string ProductName { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal DiscountValue { get; set; }

        public Order Order { get; set; }

        public ProductDetail ProductDetail { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class Sales
    {
<<<<<<< HEAD
            public Guid SaleID { get; set; }
            public string SaleDescription { get; set; }
            public decimal DiscountValue { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
=======
        public Guid SaleID { get; set; }
        public string SaleDescription { get; set; }
        public decimal DiscountValue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
>>>>>>> An-DBNew

            public virtual ICollection<ProductDetail> ProductDetail { get; set; }
    }
}

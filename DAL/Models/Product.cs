using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class Product
    {
        [Key]
        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
        public virtual ICollection<Statistics> Statistics { get; set; }
    }
}

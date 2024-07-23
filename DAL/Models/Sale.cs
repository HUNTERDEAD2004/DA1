using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Sale
    {
        [Key]
        public Guid SaleID { get; set; }

        public DateTime SaleStart { get; set; }

        public DateTime SaleEnd { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public string? UpdateBy { get; set; }

        public string? CreateBy { get; set; }

        public virtual ICollection<ProductApple> ProductApples { get; set; } = new List<ProductApple>();
    }
}

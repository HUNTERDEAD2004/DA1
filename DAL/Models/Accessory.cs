using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Accessory
    {
        [Key]
        public Guid AccessoryID { get; set; }
        public Guid ProductId { get; set; }
        public string? color { get; set; }
        public virtual ProductApple Product { get; set; } = new ProductApple();
        public string? Version { get; set; }
        public string? Material { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public string? CreateBy { get; set; }
        public string? UpdateBy { get; set;}
    }
}

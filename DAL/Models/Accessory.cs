using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DomainClass
{
    public class Accessory
    {
        public Guid AccessoryID { get; set; }
        public string? Version { get; set; }
        public string? Material { get; set; }
        public string? Weight { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string? Color { get; set; }
        public int Status { get; set; }
        public string? CreateAt { get; set; }
        public string? UpdateAt { get; set;}
    }
}

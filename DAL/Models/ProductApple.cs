using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ProductApple
    {
        public Guid ProductId { get; set; }

        public string? Name { get; set; }

        public double Price { get; set; }

        //public double DiscountPrice { get; set; }

        public double BuyingPrice { get; set; }

        public string? Description { get; set; }

        public string? CPU { get; set; }

        public string? GPU { get; set; }

        public string? RAM { get; set; }

        public string? OperatingSystem { get; set; }

        public string? BatteryCapacity { get; set; }

        public double Weight { get; set; }

        public DateTime YearOfManufacture { get; set; }

        public string? Material { get; set; }

        public string? Origin { get; set; }

        public string? Color { get; set; }

        public int Quantity { get; set; }

        public int status { get; set; }

        public string Version { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public DateTime CreateBy { get; set; }

        public DateTime UpdateBy { get; set; }

        //public virtual ICollection<AppleWatch>? AppleWatches { get; set; }

        //public virtual ICollection<Accessory>? Accessories { get; set; }
    }
}

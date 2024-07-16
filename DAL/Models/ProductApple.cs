using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DomainClass
{
    public class ProductApple
    {
        public Guid ProductId { get; set; }

        public string? Name { get; set; } 

        public double Price { get; set; }

        public double DiscountPrice { get; set; }

        public double BuyingPrice { get; set; }

        public string? Description { get; set; }

        public string? CPU { get; set; }

        public string? GPU {  get; set; }

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

        public string? Version { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public string? CreateBy { get; set; }

        public string? UpdateBy { get; set; }
    }
}

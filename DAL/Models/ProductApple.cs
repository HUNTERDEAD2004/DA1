using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ProductApple
    {
        [Key]
        public Guid ProductId { get; set; }     
        public Guid CategoryID { get; set; }
        public string? Name { get; set; }

        public double Price { get; set; }
        public double BuyingPrice { get; set; }

        public string? Description { get; set; }

        public string? CPU { get; set; }

        public string? GPU { get; set; }

        public string? RAM { get; set; }

        public string? OperatingSystem { get; set; }

        public string? BatteryCapacity { get; set; }

        public double? Weight { get; set; }

        public DateTime YearOfManufacture { get; set; }

        public string? Material { get; set; }

        public string? Origin { get; set; }

        public string? Color { get; set; }

        public int? Quantity { get; set; }

        public int? status { get; set; }

        public string? Version { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public string? CreateBy { get; set; }

        public string? UpdateBy { get; set; }
        
        public Category Category { get; set; }
        
        public virtual ICollection<AppleWatch>? AppleWatches { get; set; } = new List<AppleWatch>();
        public virtual ICollection<Accessory>? Accessorys { get; set; } = new List<Accessory>();
        public virtual ICollection<AirPod>? AirPods { get; set;} = new List<AirPod>();
        public virtual ICollection<Imac>? Imacs { get; set; } = new List<Imac>();  
        public virtual ICollection<MacBook> MacBooks { get; set; } = new List<MacBook>();
        public virtual ICollection<Ipad> Ipads { get; set; } = new List<Ipad>();
        public virtual ICollection<Iphone> Iphones { get; set; } = new List<Iphone>();
        public virtual ICollection<OderDetail> OderDetails { get; set; } = new List<OderDetail>();
        public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
        public virtual ICollection<ProductVoucher> ProductVouchers { get; set; } = new List<ProductVoucher>();
        public virtual ICollection<Warranty> Warranties { get; set; } = new List<Warranty>();
    }
}

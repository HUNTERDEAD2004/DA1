using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ProductApple
    {
        [Key]
        public Guid ProductId { get; set; }   
        
        public Guid CategoryID { get; set; }

        public Guid? SaleID { get; set; }     

        public string? Name { get; set; }

        public string? Description { get; set; }

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
        public string? imagePath {  get; set; } 


        public virtual Category Category { get; set; } = new Category();

        //public virtual AppleWatch AppleWatch { get; set; } = new AppleWatch();

        public virtual ICollection<Accessory> Accessorys { get; set; } = new List<Accessory>();

        //public virtual AirPod AirPod { get; set; } = new AirPod();

        //public virtual Imac Imac { get; set; } = new Imac();

        //public virtual MacBook MacBook { get; set; } = new MacBook();

        //public virtual Ipad Ipad { get; set; } = new Ipad();

        //public virtual Iphone Iphone { get; set; } = new Iphone();

        public virtual ICollection<OderDetail> OderDetails { get; set; } = new List<OderDetail>();

        public virtual Sale Sale { get; set; } = new Sale();

        public virtual ICollection<Warranty> Warranties { get; set; } = new List<Warranty>();
    }
}

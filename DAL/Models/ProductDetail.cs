using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Intrinsics.Arm;

namespace AppData.Models
{
    public class ProductDetail
    {
<<<<<<< HEAD
        public Guid IMEI { get; set; }
=======
        [Key]
        public Guid ProductDetailID { get; set; }
>>>>>>> An-DBNew
        public Guid ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
<<<<<<< HEAD
=======
        public decimal importPrice { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
>>>>>>> An-DBNew
        public Guid ColorID { get; set; }
        public Guid RAMID { get; set; }
        public Guid CPUID { get; set; }
        public Guid GPUID { get; set; }
        public Guid ROMID { get; set; }
        public Guid DisplayID { get; set; }
<<<<<<< HEAD
        public Guid SaleID { get; set; }
=======
        public Guid? SaleID { get; set; }
        public Guid OSID { get; set; }
        public Guid BatteryID { get; set; }
        public int Weight { get; set; }
        public int Year { get; set; }
        public Guid MaterialID { get; set; }
        public Guid OriginID { get; set; }
        public Guid VersionID { get; set; }
        public Guid RearCameraID { get; set; }
        public Guid CameraSelfieID { get; set; }
>>>>>>> An-DBNew

        public Product Product { get; set; }
        public Ram RAM { get; set; }
        public Cpu CPU { get; set; }
        public Gpu GPU { get; set; }
        public Rom ROM { get; set; }
        public Color Color { get; set; }
        public Display Display { get; set; }
        public Sales Sale { get; set; }
<<<<<<< HEAD

        public ICollection<OrderDetail> OrderDetails { get; set; }
=======
        public Voucher Voucher { get; set; }
        public OperatingSystems OperatingSystem { get; set; }
        public BatteryCapacity BatteryCapacity { get; set; }
        public Material Material { get; set; }
        public Origin Origin { get; set; }
        public Versions Version { get; set; }
        public RearCamera RearCamera { get; set; }
        public CameraSelfie CameraSelfie { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<Warranty> Warranties { get; set; }
        public ICollection<IMEI> Imeis { get; set; }
>>>>>>> An-DBNew
    }
}

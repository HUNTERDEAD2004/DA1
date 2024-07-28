﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Intrinsics.Arm;

namespace AppData.Models
{
    public class ProductDetail
    {
        public Guid IMEI { get; set; }
        public Guid ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Guid ColorID { get; set; }
        public string Warranty { get; set; }
        public Guid RAMID { get; set; }
        public Guid CPUID { get; set; }
        public Guid GPUID { get; set; }
        public Guid ROMID { get; set; }
        public Guid DisplayID { get; set; }
        public Guid SaleID { get; set; }

        public Product Product { get; set; }
        public Ram RAM { get; set; }
        public Cpu CPU { get; set; }
        public Gpu GPU { get; set; }
        public Rom ROM { get; set; }
        public Color Color { get; set; }
        public Display Display { get; set; }
        public Sales Sale { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
        public Warranty warranty { get; set; }
    }
}

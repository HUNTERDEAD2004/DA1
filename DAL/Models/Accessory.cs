﻿using System;
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
        public ProductApple Product { get; set; }
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
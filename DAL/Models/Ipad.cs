﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Ipad
    {
        [Key]
        public Guid IpadIMEI { get; set; }
        public Guid ProductId { get; set; }
        public string? Display { get; set; }
        public string? RearCamera { get; set; }
        public string? CameraSelfie { get; set; }
        public string? CreateBy { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        [ForeignKey("ProductId")]
        public virtual ProductApple ProductApple { get; set; }
        //public virtual ProductApple Product { get; set; } = new ProductApple();
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public ProductApple Product {  get; set; }
    }
}
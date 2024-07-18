﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class AppleWatch
    {
        [Key]
        public Guid AppleWatchId { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public DateTime CreateBy { get; set; }

        public DateTime UpdateBy { get; set; }
        public Guid ProductId {  get; set; }    
        public string? Display { get; set; }
        public ProductApple Product { get; set; }
    };
}
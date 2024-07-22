using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Warranty
    {
        [Key]
        public Guid WarrantyId { get; set; }
        public Guid ProductId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Terms { get; set; }
        public string? Type { get; set; }
        public string? CreateBy { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public string? UpdateBy { get; set; }
        public virtual ProductApple Product { get; set; }
    }
}

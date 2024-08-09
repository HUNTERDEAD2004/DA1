using AppData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class IMEI
    {
        [Key]
        [MaxLength(15)]
        public string ImeiID { get; set; }
        public Guid ProductDetailID { get; set; }
        public Guid? OrderDetailID { get; set; } 
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public ProductDetail ProductDetail { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public ICollection<Warranty> Warranties { get; set; }


    }
}

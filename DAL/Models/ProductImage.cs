using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ProductImage
    {
        public Guid ImageID { get; set; }
        public string? Desscription { get; set; }
        public Guid ProductId { get; set; }
        public string? ImagePath1 { get; set; }
        public string? ImagePath2 { get; set; }
        public string? ImagePath3 { get; set; }
        public DateTime CreateAt { get; set; }  
        public DateTime UpdateAt { get; set; }
    }
}

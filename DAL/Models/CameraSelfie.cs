using AppData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CameraSelfie
    {
        [Key]
        public Guid CameraSelfieID { get; set; }
        public string CameraSelfieDetails { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }

    }
}

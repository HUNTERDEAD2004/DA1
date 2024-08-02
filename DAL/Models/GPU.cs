using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class Gpu
    {
        [Key]
        public Guid GPUID { get; set; }
        public string GPUName { get; set; }
        public string GPUMemory { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}

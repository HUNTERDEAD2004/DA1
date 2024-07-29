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

        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class Cpu
    {
        [Key]
        public Guid CPUID { get; set; }
        public string CPUName { get; set; }
        public int CPUCores { get; set; }
        public int CPUThreads { get; set; }
        public string CPUClockSpeed { get; set; }

        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}

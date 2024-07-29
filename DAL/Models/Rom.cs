using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class Rom
    {
        public Guid ROMID { get; set; }
        public string ROMSize { get; set; }

        public ICollection<ProductDetail> ProductDetails { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class Ram
    {
        public Guid RAMID { get; set; }
        public string RAMSize { get; set; }
        public string RAMType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public ICollection<ProductDetail> ProductDetails { get; set; }
    }
}

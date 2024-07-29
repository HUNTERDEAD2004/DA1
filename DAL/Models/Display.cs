using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class Display
    {
        [Key]
        public Guid DisplayID { get; set; }
        public string DisplayName { get; set; }

        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}

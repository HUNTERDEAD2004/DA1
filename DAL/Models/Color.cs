using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class Color
    {
        [Key]
        public Guid ColorID { get; set; }
        public string ColorName { get; set; }

        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}

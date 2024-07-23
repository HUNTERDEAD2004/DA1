using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Category
    {
        [Key]
        public Guid CategoryID { get; set; }

        public string? CreateBy { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public string? UpdateBy { get; set; }

        public virtual ICollection<ProductApple> ProductApples { get;} = new List<ProductApple>();
    }
}

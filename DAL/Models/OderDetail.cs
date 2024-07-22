using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class OderDetail
    {
        [Key]
        public Guid OrderDetailsID { get; set; }
        public Guid ProductId { get; set; }
        public Guid OderID { get; set; }
        public int Quantity { get; set; }
        public double Price {  get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public string? UpdateBy { get; set; }
        public string? CreateBy { get; set; }
        public virtual ProductApple Product { get; set; }
        public virtual Oder Oder { get; set; }
    }
}

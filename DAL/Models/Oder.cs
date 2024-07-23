using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models   
{
    public class Oder
    {
        [Key]
        public Guid OderID { get; set; }  
        
        public Guid UserID { get; set; }

        public Guid CustomerID { get; set; }

        public int Quantity {get; set; }

        public double Price { get; set; }

        public double TotalPrice { get; set; }  

        public int Status {  get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public string? CreateBy { get; set; }

        public string? UpdateBy { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<OderDetail> OderDetails { get; set; } = new List<OderDetail>();
    }
}

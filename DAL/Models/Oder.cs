using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DomainClass
{
    public class Oder
    {
        public Guid OderID { get; set; }    
        public int TotalQuantity {get; set; }
        public double TotalPrice { get; set; }  
        public int Status {  get; set; }
        public DateTime CreateAt { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateAt { get; set; }
        public string UpdateBy { get; set; }
    }
}

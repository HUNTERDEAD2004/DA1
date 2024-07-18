using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class DiscountPrice
    {
        public Guid DiscountPriceID { get; set; }
        public DateTime CreateAt { get; set; }  
        public DateTime UpdateAt { get; set; }
        public DateTime EndTime { get; set; }
        public string Percent {  get; set; }

    }
}

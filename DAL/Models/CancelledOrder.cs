using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CancelledOrder
    {
        public int CancelledOrderID { get; set; }
        public Guid OrderID { get; set; } // Foreign Key
        public string Reason { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        // Navigation property
        public Order Order { get; set; }
    }
}

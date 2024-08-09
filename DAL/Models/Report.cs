using AppData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Report
    {
        [Key]
        public Guid ReportID { get; set; }
        public DateTime ReportDate { get; set; }
        public int TotalSold { get; set; }
        public decimal TotalAmount { get; set; }
        public int SuccessfulOrders { get; set; }
        public int PendingOrders { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        // Navigation property
        public ICollection<Order> Orders { get; set; }
    }
}

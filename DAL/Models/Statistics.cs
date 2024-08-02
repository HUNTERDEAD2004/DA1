using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class Statistics
    {
        public Guid StatisticID { get; set; }
        public DateTime ReportDate { get; set; }
        public DateTime Note { get; set; }
        [ForeignKey("ProductID")]
        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public int TotalQuantitySold { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public Product Product { get; set; }
    }
}

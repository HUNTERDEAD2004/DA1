using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Warranty
    {
        [Key]
        public Guid WarrantyId { get; set; }
        public Guid ProductId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Terms { get; set; }
        // Other properties

        public ProductApple Product { get; set; }
    }
}

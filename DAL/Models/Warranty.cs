using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class Warranty
    {
        public Guid WarrantyID { get; set; }
<<<<<<< HEAD
        public Guid IMEI { get; set; }
=======
        public Guid ProductDetailID { get; set; }
>>>>>>> An-DBNew
        public DateTime WarrantyStartDate { get; set; }
        public DateTime WarrantyEndDate { get; set; }

        public ProductDetail ProductDetail { get; set; }
    }
}

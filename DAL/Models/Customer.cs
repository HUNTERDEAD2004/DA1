using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class Customer
    {
        [Key]
        public Guid CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int Age {  get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int Point { get; set; }
    }
}

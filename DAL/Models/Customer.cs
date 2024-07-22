using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Customer
    {
        public Guid CustomerID { get; set; }

        public string? Name { get; set; }

        public int Age { get; set; }

        public string? Email { get; set; }

        public string? Number { get; set; }

        public string? Gender { get; set; }

        public int Point { get; set; }

        public int Status { get; set; }

        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public string? CreateBy { get; set; }
        public string? UpdateBy { get; set; }

        public virtual ICollection<Oder> Oders { get; set;} = new  List<Oder>();    
    }
}

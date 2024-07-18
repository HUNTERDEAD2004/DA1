using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Role
    {
        public Guid RoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid UserID { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }  
        public virtual ICollection<UserRole> UserRoles { get; set; }    
    }
}

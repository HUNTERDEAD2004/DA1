using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class UserRole
    {
        [Key]
        public Guid UserRoleID { get; set; } 
        public Guid RoleId { get; set; }
        public Guid UserID { get; set; }
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }

    }
}

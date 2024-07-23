using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class UserRole
    {
        public Guid UserRoleID { get; set; }

        public Guid UserID { get; set; }

        public Guid RoleID { get; set; }

        public virtual User User { get; set; } = new User();

        public virtual Role Role { get; set; } = new Role();
    }
}

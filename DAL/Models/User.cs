using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        [Key]
        public Guid UserID { get; set; }
        [Required]
        [StringLength (256)]
        public string? Name { get; set; }
        [Required]
        public string? Adress { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public string? UserName { get; set; }
        [Required, MinLength(8)]
        [PasswordPropertyText]
        public string? Password { get; set; }   

        public int Status { get; set; }

        public DateTime BirthOfDate { get; set; }  
        
        public string? Gender { get; set; }

        public DateTime CreateAt { get; set;}

        public DateTime UpdateAt { get; set;}

        public string? CreateBy { get; set; }

        public string? UpdateBy { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

        public virtual ICollection<Oder> Oders { get; set; } = new List<Oder>();
    }
}

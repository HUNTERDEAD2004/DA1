using System.ComponentModel.DataAnnotations;

namespace AppData.Models
{
    public class Account
    {
        [Key]
        public Guid AccountID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public string Roles { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime BOD { get; set;}
        public string Gender { get; set;}
        public decimal Wage { get; set;}
        public DateTime CreateAt { get; set;}
        public DateTime UpdateAt { get; set;}
        public string CreateBy { get; set;}
        public string UpdateBy { get; set;}
    }
}

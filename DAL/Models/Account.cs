using System.ComponentModel.DataAnnotations;

namespace AppData.Models
{
    public class Account
    {
        [Key]
        public Guid AccountID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public string Roles { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string BOD { get; set;}
        public string Gender { get; set;}
        public string Wage { get; set;}
        public string CreateAt { get; set;}
        public string UpdateAt { get; set;}
        public string CreateBy { get; set;}
        public string UpdateBy { get; set;}
    }
}

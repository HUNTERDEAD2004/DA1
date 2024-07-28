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
    }
}

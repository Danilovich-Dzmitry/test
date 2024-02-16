using System.ComponentModel.DataAnnotations;

namespace Homologacja.Models
{
    public class Login
    {
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Hasło")]
        public string Password { get; set; }
    }
}

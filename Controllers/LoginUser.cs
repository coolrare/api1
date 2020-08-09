using System.ComponentModel.DataAnnotations;

namespace api1.Controllers
{
    public class LoginUser
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
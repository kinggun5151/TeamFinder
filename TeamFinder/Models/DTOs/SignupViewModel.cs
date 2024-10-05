using System.ComponentModel.DataAnnotations;

namespace TeamFinder.Models.DTOs
{
    public class SignupViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}

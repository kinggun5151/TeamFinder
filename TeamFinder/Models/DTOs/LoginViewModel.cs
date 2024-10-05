using System.ComponentModel.DataAnnotations;

namespace TeamFinder.Models.DTOs
{
    public class LoginViewModel
    {
        [Required]
        public string UserNameorEmail {  get; set; }

        [Required]
        public string Password { get; set; }

    }
}

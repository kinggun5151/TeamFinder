using System.ComponentModel.DataAnnotations;

namespace TeamFinder.Models.DTOs
{
    public class FullSignUpViewModel
    {
        [StringLength(50)]
        public string Name { get; set; }


        public string org { get; set; }


        public string Address { get; set; }


        public string Occupation { get; set; }

        [Required]
        public int Age { get; set; }


        public string Gender { get; set; }


        public string? Description { get; set; }
    }
}

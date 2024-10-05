using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamFinder.Models.Entities
{

    public class Info
    {
        [Key]
        public int PersonalInfoId { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }

        public Person Person { get; set; }

        [StringLength(50)]
        public string? Name { get; set; }


        public string? org { get; set; }


        public string? Address { get; set; }


        public string? Occupation { get; set; }


        public int? Age { get; set; }


        public string? Gender { get; set; }


        public string? Description { get; set; }
    }
}

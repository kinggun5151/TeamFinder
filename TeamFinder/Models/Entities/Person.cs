using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace TeamFinder.Models.Entities
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }


        public string? Status { get; set; }

        [Required]
        public Info PersonalInfo { get; set; }

        public int XP { get; set; }


        public int Level { get; set; }

        public int Rank { get; set; }

        public int Coins { get; set; }

        public string? Class { get; set; }

        public List<int> GuildsIds { get; set; }

        public List<int> PartysIds { get; set; }

        public List<Skill> Skills { get; set; }

        public List<int> CreatedMissionsIds {  get; set; }

        
        public List<Mission>? Missions { get; set; }

        public List<Test> CompletedTests { get; set; }

        public Person()
        {
            CreatedMissionsIds= new List<int>();
            GuildsIds= new List<int>();
            PartysIds= new List<int>();
            PersonalInfo = new Info();
            XP = 0;
            Level = 0;
            
        }
    }
}

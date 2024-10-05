using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TeamFinder.Models.Entities
{
    public class Mission
    {
        [Key]
        public int MissionId { get; set; }


        
        public int? CreatorId { get; set; }
        

        
        public List<Person>? Missionarys { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Class { get; set; }

        [Required]
        public string Type { get; set; }


        public bool IsActive { get; set; }

        [Required]
        public int MemberLimit { get; set; }

        public int Rewards_XP { get; set; }

        public int Rewards_Money { get; set; }

        public int Rewards_Coins { get; set; }

        [Required]
        public string Req_Address { get; set; }

        [Required]
        public int Req_Age_Up { get; set; }

        [Required]
        public int Req_Age_Down { get; set; }

        [Required]
        public string Req_Gender { get; set; }

        [Required]
        public List<string> Req_Skills { get; set; }

        public Mission()
        {
            //MissionarysIds= new List<int>();
            IsActive = true;
        }
    }

    public class SuggestedMissionTemplet
    {
        [Key]
        public int MissionTempletId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Class { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public int MemberLimit { get; set; }

        public int Rewards_XP { get; set; }

        public int Rewards_Money { get; set; }

        public int Rewards_Coins { get; set; }

        [Required]
        public string Req_Address { get; set; }

        [Required]
        public int Req_Age_Up { get; set; }

        [Required]
        public int Req_Age_Down { get; set; }

        [Required]
        public string Req_Gender { get; set; }

        [Required]
        public List<string> Req_Skills { get; set; }
    }
}

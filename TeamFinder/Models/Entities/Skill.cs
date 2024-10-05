using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamFinder.Models.Entities
{
    public class SkillTemplet
    {
        [Key]
        public int SkillTempletId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type {  get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Class { get; set; }

        [Required]
        public string Rarity { get; set; }

        

        
        public List<string> Req_Tests { get; set; }

        
        public List<string> Req_Skills { get; set; }

        public int Req_lvl {  get; set; }

        public SkillTemplet()
        {
            Req_Tests = new List<string>();
            Req_Skills = new List<string>();
            //Req_lvl = 0;
        }
        
        
    }

    public class Skill 
    {
        [Key]
        public int SkillId { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public Person Person { get; set; }

        [ForeignKey("SkillTemplet")]
        public int SkillTempletId { get; set; }
        public SkillTemplet SkillTemplet { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Class { get; set; }

        [Required]
        public string Rarity { get; set; }

        public int Level { get; set; }

        public int XP { get; set; }

        public Skill(string name,string type,string Class)
        {

            Name = name;
            this.Class= Class;
            Type = type;
            Level = 1;
            XP = 0;
        }
    }
}

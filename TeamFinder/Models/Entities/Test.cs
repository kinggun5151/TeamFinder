using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TeamFinder.Models.Entities
{
    public class TestTemplet
    {
        [Key]
        public int TestTempletId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Class { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public int Reward_XP {  get; set; }


        [Required]
        public List<string> Req_Tests { get; set; }

        [Required]
        public List<string> Req_Skills { get; set; }

        //TODO Attention Requaierd
        public List<string> Quaestiones { get; set; }
        public List<string> Links { get; set; }

        public List<Option> Options { get; set; }

        public TestTemplet()
        {
            Quaestiones= new List<string>();
            Links= new List<string>();
        }


    }


    public class Test 
    {
        [Key]
        public int TestId { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public Person Person { get; set; }


        [ForeignKey("TestTemplet")]
        public int TestTempletId { get; set; }
        public SkillTemplet TestTemplet { get; set; }

        [Required]
        public string Name {  get; set; }

        [Required]
        public string Class { get; set; }

        [Required]
        public string Type { get; set; }


        public Test(string name, string type, string Class)
        {
            Name = name;
            this.Class = Class;
            Type = type;
        }

    }
}

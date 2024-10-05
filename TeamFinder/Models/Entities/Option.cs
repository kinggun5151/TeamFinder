using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TeamFinder.Models.Entities
{
    public class Option
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("TestTemplet")]
        public int TestTempletId { get; set; }
        public TestTemplet TestTemplet { get; set; }

        //TODO Attention Requaierd
        public List<string> Values { get; set; }
        public List<string> Links { get; set; }

        public string Answ { get; set; }

    }
}

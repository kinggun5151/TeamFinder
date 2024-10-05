using TeamFinder.Models.Entities;

namespace TeamFinder.Functions.PersonF
{

    public static class PersonF 
    {
        public static void LevelUp(Person person)
        {
            if (person.XP >= person.Level * 1000)
            {
                person.XP -= 1000;
                person.Level++;
            }
        }
        public static void LevelUp(Skill skill)
        {
            if (skill.XP >= skill.Level * 1000)
            {
                skill.XP -= 1000 * skill.Level;
                skill.Level++;
            }
        }

        


    }
}

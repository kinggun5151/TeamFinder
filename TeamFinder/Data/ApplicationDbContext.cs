using Microsoft.EntityFrameworkCore;
using TeamFinder.Models.Entities;



namespace TeamFinder.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Person { get; set; }

        public DbSet<Info> Info { get; set; }

        public DbSet<SkillTemplet> SkillTemplets { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<TestTemplet> TestTemplets { get; set; }

        public DbSet<Test> Tests { get; set; }

        public DbSet<Mission> Missions { get; set; }

        public DbSet<SuggestedMissionTemplet> SuggestedMissionTemplets { get; set; }

        public DbSet<Option> Options { get; set; }
        

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Person>().HasMany(p => p.Skills).WithOne(s => s.Person);

        //}

    }
}

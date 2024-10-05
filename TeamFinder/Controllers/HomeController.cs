using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TeamFinder.Data;
using TeamFinder.Models;
using TeamFinder.Models.Entities;


namespace TeamFinder.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            
            _db.Person.Add(new Person() { Username = "sad", Password = "asda", PhoneNumber = "asdad", Email = "asda" });
            
            //_db.SkillTemplets.Add(new SkillTemplet()
            //{
            //    Name = "adad",
            //    Type = "dasdad",
            //    Class = "asda",
            //    Description = "asdad",
            //    Rarity = "asda",
            //    Req_Skills = new List<string>(),
            //    Req_Tests = new List<string>()
            //});
            //Person person = _db.Person.Find(1);
            
            //Func.LevelUp(person);
            //person.Skills = _db.Skills.Where(e => e.PersonId == person.PersonId).ToList();
            //SkillTemplet sss = _db.SkillTemplets.Find(1);
            //person.Skills.Add(new Skill(sss.Name,sss.Type,sss.Class) { SkillTemplet = sss, SkillTempletId = sss.SkillTempletId });
            
            //person.Username = "bad";
            _db.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamFinder.Data;
using TeamFinder.Models.Entities;

namespace TeamFinder.Controllers
{
    public class AddMissionController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AddMissionController(ApplicationDbContext db)
        {

            _db = db;
        }
        [Authorize]
        public IActionResult AddMission()
        {
            
            return View();
        }

        [Authorize]
        public IActionResult AddMissionPost(Mission data)
        {
            Person user = _db.Person.Include(x => x.Missions).
                Where(x => x.PersonId == Int32.Parse(User.FindFirst("Id").Value)).FirstOrDefault();
            user.Missions.Add(data);
            _db.SaveChanges();
            return View();
        }
    }
}

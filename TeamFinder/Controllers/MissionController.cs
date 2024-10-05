using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamFinder.Data;
using TeamFinder.Models.Entities;

namespace TeamFinder.Controllers
{
    public class MissionController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MissionController(ApplicationDbContext db)
        {

            _db = db;
        }
        [Authorize]
        public IActionResult MyMission()
        {
            List<Mission> missions = _db.Person.Include(x => x.Missions).
                Where(x => x.PersonId == Int32.Parse(User.FindFirst("Id").Value)).FirstOrDefault().Missions;

            return View(missions);
        }
    }
}

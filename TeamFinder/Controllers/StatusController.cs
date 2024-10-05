using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.DotNet;
using TeamFinder.Data;
using static System.Net.Mime.MediaTypeNames;

namespace TeamFinder.Controllers
{
    public class StatusController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StatusController(ApplicationDbContext db )
        {
            _db = db;
        }
        //Get

        [Authorize]
        public IActionResult StatusPage()
        {
            
            //اینجا ای دی رو باید دستی وارد کنی
            int Id = Int32.Parse(User.FindFirst("Id").Value);
            var people = _db.Person.Find(Id);
            return View(people);
        }
    }
}

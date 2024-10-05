using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamFinder.Data;
using TeamFinder.Models.DTOs;
using TeamFinder.Models.Entities;

namespace TeamFinder.Controllers
{
    public class FullSignUpController : Controller
    {
        private readonly ApplicationDbContext _db;
        public FullSignUpController(ApplicationDbContext db)
        {

            _db = db;
        }

        [Authorize]
        public IActionResult Index()
        {
            Person user = _db.Person.Include(x => x.PersonalInfo).
                Where(x => x.PersonId == Int32.Parse(User.FindFirst("Id").Value)).FirstOrDefault();
            
            
            return View(user);
        }

        [HttpPost]
        [Authorize]
        public IActionResult FullSignUpPsot(FullSignUpViewModel data)
        {
            if (ModelState.IsValid)
            {
                Person user = _db.Person.Include(x => x.PersonalInfo).
                Where(x => x.PersonId == Int32.Parse(User.FindFirst("Id").Value)).FirstOrDefault();
                user.PersonalInfo.Name = data.Name;
                user.PersonalInfo.Address = data.Address;
                user.PersonalInfo.Age= data.Age;
                user.PersonalInfo.Gender = data.Gender;
                user.PersonalInfo.Description = data.Description;
                user.PersonalInfo.org = data.org;
                user.PersonalInfo.Occupation = data.Occupation;
                user.Status = "FullSignUp";
                _db.SaveChanges();
                return RedirectToAction("StatusView", "Status");
            }
                
            
            return View();
        }
    }
}

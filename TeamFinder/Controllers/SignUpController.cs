using Microsoft.AspNetCore.Mvc;
using TeamFinder.Data;
using TeamFinder.Models.DTOs;
using TeamFinder.Models.Entities;

namespace TeamFinder.Controllers
{
    public class SignUpController : Controller
    {

        private readonly ApplicationDbContext _db;

        public SignUpController(ApplicationDbContext db)
        {

            _db = db;
        }

        //Get
        public IActionResult SignUpView()
        {
            return View();
        }

        //Post
        [HttpPost]
        public IActionResult SignUpPost(SignupViewModel model)
        {
            if (ModelState.IsValid)
            {
                _db.Person.Add(new Person() { 
                    Username = model.Username,
                    Password = model.Password,
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email });
                _db.SaveChanges();
                return RedirectToAction("LoginView", "Login");
                
            }
            return RedirectToAction("SignUpView", "SignUp");
        }
    }
}

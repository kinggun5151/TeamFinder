using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TeamFinder.Data;
using TeamFinder.Models.DTOs;
using TeamFinder.Models.Entities;

namespace TeamFinder.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LoginController( ApplicationDbContext db)
        {
            
            _db = db;
        }

        //Get
        public IActionResult LoginView()
        {
            return View();
        }


        //Post
        [HttpPost]
        public IActionResult LoginPost(LoginViewModel model) 
        {

            if (ModelState.IsValid)
            {
                Person user = _db.Person.Where(x => ((x.Username == model.UserNameorEmail||x.Email==model.UserNameorEmail) && x.Password == model.Password)).FirstOrDefault();
                if (user != null)
                {
                    var claimes = new List<Claim> {
                        new Claim(ClaimTypes.Name,user.Username),
                        new Claim("Id",user.PersonId.ToString()),
                        new Claim(ClaimTypes.Role,"User")
                    };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claimes,CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                    return RedirectToAction("StatusPage", "Status");
                }
                else
                {
                    return View(model);
                }
            }

            return View(model);
        }

    }
}

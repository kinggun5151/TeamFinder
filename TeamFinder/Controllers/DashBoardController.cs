using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TeamFinder.Services.Interface;

namespace TeamFinder.Controllers
{
    public class DashBoardController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}

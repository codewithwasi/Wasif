using Microsoft.AspNetCore.Mvc;

namespace Wasif_web_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

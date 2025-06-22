using Microsoft.AspNetCore.Mvc;

namespace ProjectCV.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

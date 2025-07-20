using Microsoft.AspNetCore.Mvc;

namespace ProjectCV.WEBUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

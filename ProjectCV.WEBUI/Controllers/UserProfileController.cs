using Microsoft.AspNetCore.Mvc;

namespace ProjectCV.WEBUI.Controllers
{
    public class UserProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

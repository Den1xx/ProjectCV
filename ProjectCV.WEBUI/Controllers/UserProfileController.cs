using Microsoft.AspNetCore.Mvc;
using ProjectCV.ENTITY.Entities;

namespace ProjectCV.WEBUI.Controllers
{
    public class UserProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public void Edit(int id)
        {

        }
    }
}

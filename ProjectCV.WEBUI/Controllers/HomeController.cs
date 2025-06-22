using Microsoft.AspNetCore.Mvc;
using ProjectCV.BLL.Concrete;

namespace ProjectCV.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserProfileService _userProfileService;
        public HomeController()
        {
            _userProfileService = new UserProfileService();
        }
        public IActionResult Index()
        {
            var userProfile = _userProfileService.GetUserProfile();
            return View(userProfile);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using ProjectCV.BLL.Concrete;
using ProjectCV.ENTITY.Entities;

namespace ProjectCV.WEBUI.ViewComponents.UserProfile
{
    public class _SelectUserProfileViewComponentPartial : ViewComponent
    {
        private readonly UserProfileService _userProfileService;
        public _SelectUserProfileViewComponentPartial()
        {
            _userProfileService = new UserProfileService();
        }
        public IViewComponentResult Invoke()
        {
            var userProfile = _userProfileService.GetUserProfile();
            return View(userProfile);
        }
    }
}

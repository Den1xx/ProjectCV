using Microsoft.AspNetCore.Mvc;
using ProjectCV.BLL;
using ProjectCV.ENTITY.Entities;

namespace ProjectCV.WEBUI.ViewComponents
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

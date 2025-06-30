using Microsoft.AspNetCore.Mvc;
using ProjectCV.BLL;

namespace ProjectCV.WEBUI.ViewComponents
{
    public class _HeroSectionViewComponentPartial : ViewComponent
    {
        private readonly UserProfileService userProfileService;
        public _HeroSectionViewComponentPartial()
        {
            userProfileService = new UserProfileService();
        }
        public IViewComponentResult Invoke()
        {
            var hero = userProfileService.GetUserProfile();
            return View(hero);
        }
    }
}

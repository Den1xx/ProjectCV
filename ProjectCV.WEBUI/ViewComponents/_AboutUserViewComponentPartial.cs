using Microsoft.AspNetCore.Mvc;
using ProjectCV.BLL;

namespace ProjectCV.WEBUI.ViewComponents.UserProfile
{
    public class _AboutUserViewComponentPartial : ViewComponent
    {
        private readonly AboutService _aboutService;
        public _AboutUserViewComponentPartial()
        {
            _aboutService = new AboutService();
        }
        public IViewComponentResult Invoke()
        {
            var about = _aboutService.GetAbout();
            return View(about);
        }
    }
}

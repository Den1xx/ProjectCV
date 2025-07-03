using Microsoft.AspNetCore.Mvc;
using ProjectCV.BLL;

namespace ProjectCV.WEBUI.ViewComponents
{
    public class _ExperienceUserViewComponentPartial : ViewComponent
    {
        private readonly ExperienceService _experienceService;
        public _ExperienceUserViewComponentPartial()
        {
            _experienceService = new ExperienceService();
        }
        public IViewComponentResult Invoke()
        {
            var exp = _experienceService.GetExperiences();
            return View(exp);
        }
    }
}

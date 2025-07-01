using Microsoft.AspNetCore.Mvc;
using ProjectCV.BLL;

namespace ProjectCV.WEBUI.ViewComponents
{
    public class _SkillsUserViewComponentPartial : ViewComponent
    {
        private readonly SkillService _skillService;
        public _SkillsUserViewComponentPartial()
        {
            _skillService = new SkillService();
        }
        public IViewComponentResult Invoke()
        {
            var skills = _skillService.GetSkills();
            return View(skills);
        }
    }
}

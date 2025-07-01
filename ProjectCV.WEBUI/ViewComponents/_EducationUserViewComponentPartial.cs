using Microsoft.AspNetCore.Mvc;
using ProjectCV.BLL;

namespace ProjectCV.WEBUI.ViewComponents
{
    public class _EducationUserViewComponentPartial : ViewComponent
    {
        private readonly EducationService _educationService;
        public _EducationUserViewComponentPartial()
        {
            _educationService = new EducationService();
        }
        public IViewComponentResult Invoke()
        {
            var educationList = _educationService.GetEducation();
            return View(educationList);
        }
    }
}

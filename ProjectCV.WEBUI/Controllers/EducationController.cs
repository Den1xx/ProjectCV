using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectCV.BLL;
using ProjectCV.DAL.DTOs.EducationUpdateDTO;
using ProjectCV.DAL.DTOs.SkillUpdateDTO;
using ProjectCV.ENTITY.Entities;

namespace ProjectCV.WEBUI.Controllers
{
    public class EducationController : Controller
    {
        private readonly EducationService _educationService;
        private readonly IMapper _mapper;

        public EducationController()
        {
            _educationService = new EducationService();
            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EducationUpdateDTO, Education>();
                cfg.CreateMap<Education, EducationUpdateDTO>();
            }).CreateMapper();
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Update()
        {
            var education = _educationService.GetEducation();
            var educationDtos = _mapper.Map<List<EducationUpdateDTO>>(education);
            return View(educationDtos);
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectCV.BLL;
using ProjectCV.DAL.DTOs.UserProfileDto;
using ProjectCV.ENTITY.Entities;

namespace ProjectCV.WEBUI.Controllers
{
    public class SkillController : Controller
    {
        private readonly IMapper _mapper;
        private readonly SkillService _skillService;

        public SkillController()
        {
            _skillService = new SkillService();
            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SkillUpdateDTO, Skill>();
                cfg.CreateMap<Skill, SkillUpdateDTO>();
            }).CreateMapper();
        }
        public IActionResult Index()
        {
            var skills = _skillService.GetSkills();
            return View(skills);
        }
    }
}

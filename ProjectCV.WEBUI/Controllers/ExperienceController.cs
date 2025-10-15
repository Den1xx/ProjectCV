using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectCV.BLL;
using ProjectCV.DAL.DTOs.ExperienceUpdateDTO;
using ProjectCV.ENTITY.Entities;

namespace ProjectCV.WEBUI.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly ExperienceService _experienceService;
        private readonly IMapper _mapper;
        public ExperienceController()
        {
            _experienceService = new ExperienceService();
            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ExperienceUpdateDTO, Experience>();
                cfg.CreateMap<Experience, ExperienceUpdateDTO>();
            }).CreateMapper();
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Update()
        {
            var experiences = _experienceService.GetExperiences();
            var experienceDto = _mapper.Map<List<ExperienceUpdateDTO>>(experiences);
            return View(experienceDto);
        }
        [HttpPost]
        public async Task<ActionResult> Update(List<ExperienceUpdateDTO> experiences)
        {
            if (ModelState.IsValid)
            {
                foreach (var exp in experiences)
                {
                    var experience = _mapper.Map<Experience>(exp);
                    _experienceService.Update(experience);
                }
                return RedirectToAction("Update");
            }
            return View(experiences);
        }
    }
}

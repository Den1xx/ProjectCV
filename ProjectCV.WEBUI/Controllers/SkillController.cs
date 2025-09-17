using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectCV.BLL;
using ProjectCV.DAL.DTOs.SkillUpdateDTO;
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

        public ActionResult Update()
        {
            var skills = _skillService.GetSkills();
            var skillDtos = _mapper.Map<List<SkillUpdateDTO>>(skills);
            return View(skillDtos); 

            //if (id == null)
            //{
            //    return BadRequest("Invalid skill ID.");
            //}
            //var skill = _skillService.GetSkills().ToList();
            //if (skill == null)
            //{
            //    return NotFound("Skill not found.");
            //}
            //var skillDto = _mapper.Map<List<SkillUpdateDTO>>(skill);
            //return View(skillDto);
        }
        [HttpPost]
        public async Task<ActionResult> Update(List<SkillUpdateDTO> models)
        {
            if (ModelState.IsValid)
            {
                foreach (var m in models)
                {
                    var skill = _mapper.Map<Skill>(m);
                    _skillService.Update(skill);

                }
                return RedirectToAction("Update");

            }
            return View(models);
        }


    }
}

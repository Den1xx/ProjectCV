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
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(EducationUpdateDTO model)
        {
            if (ModelState.IsValid)
            {

                var educations = _mapper.Map<Education>(model);
                _educationService.Create(educations);

                return RedirectToAction("Update");
            }

            return View(model);
        }

        public ActionResult Update()
        {
            var education = _educationService.GetEducation();
            var educationDtos = _mapper.Map<List<EducationUpdateDTO>>(education);
            return View(educationDtos);
        }
        [HttpPost]
        public async Task<ActionResult> Update(List<EducationUpdateDTO> models)
        {
            if (ModelState.IsValid)
            {
                foreach (var item in models)
                {
                    var educations = _mapper.Map<Education>(item);
                    _educationService.Update(educations);
                }
                return RedirectToAction("Update");
            }

            return View(models);
        }
        public void Delete(int id)
        {
            var ids = _educationService.Find(id);
            if (ids != null)
            {
                _educationService.Delete(ids);
            }
        }
    }
}

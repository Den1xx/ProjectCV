using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using ProjectCV.BLL;
using ProjectCV.DAL.DTOs.CertificatesDTO;
using ProjectCV.DAL.DTOs.CertificatesUpdateDTO;
using ProjectCV.DAL.DTOs.EducationDTO;
using ProjectCV.DAL.DTOs.EducationUpdateDTO;
using ProjectCV.ENTITY.Entities;

namespace ProjectCV.WEBUI.Controllers
{
    public class CertificateController : Controller
    {
        private readonly CertificateService _certificateService;
        private readonly IMapper _mapper;
        public CertificateController()
        {
            _certificateService = new CertificateService();
            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CertificatesUpdateDTO, Certificate>();
                cfg.CreateMap<Certificate, CertificatesUpdateDTO>();
                cfg.CreateMap<Certificate, CertificatesCreateDTO>();
                cfg.CreateMap<CertificatesCreateDTO, Certificate>();
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
        public async Task<ActionResult> Create(CertificatesCreateDTO certificateDto)
        {
            if (ModelState.IsValid)
            {
                var certificate = _mapper.Map<Certificate>(certificateDto);
                _certificateService.Create(certificate);

                return RedirectToAction("Update");
            }
            return View(certificateDto);
        }

        public ActionResult Update()
        {
            var certificate = _certificateService.GetAllCertificates();
            var certificateDto = _mapper.Map<List<CertificatesUpdateDTO>>(certificate);
            return View(certificateDto);
        }
        [HttpPost]
        public async Task<ActionResult> Update(List<CertificatesUpdateDTO> certificates)
        {
            if (ModelState.IsValid)
            {
                foreach (var cert in certificates)
                {
                    var certificate = _mapper.Map<Certificate>(cert);
                    _certificateService.Update(certificate);
                }
                return RedirectToAction("Update");
            }
            return View(certificates);
        }
    }
}

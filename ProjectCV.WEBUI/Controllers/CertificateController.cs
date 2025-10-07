using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using ProjectCV.BLL;
using ProjectCV.DAL.DTOs.CertificatesUpdateDTO;
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
            }).CreateMapper();
        }
        public IActionResult Index()
        {
            return View();
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

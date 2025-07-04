using Microsoft.AspNetCore.Mvc;
using ProjectCV.BLL;

namespace ProjectCV.WEBUI.ViewComponents
{
    public class _CertificateUserViewComponentPartial : ViewComponent
    {
        private readonly CertificateService _certificateService;
        public _CertificateUserViewComponentPartial()
        {
            _certificateService = new CertificateService();
        }
        public IViewComponentResult Invoke()
        {
            var certificates = _certificateService.GetAllCertificates();
            return View(certificates);
        }
    }
}

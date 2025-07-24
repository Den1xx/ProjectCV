using Microsoft.AspNetCore.Mvc;
using ProjectCV.BLL;

namespace ProjectCV.Controllers
{
    public class HomeController : Controller    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}

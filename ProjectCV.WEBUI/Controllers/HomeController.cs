using Microsoft.AspNetCore.Mvc;
using ProjectCV.BLL;
using System.Threading.Tasks;

namespace ProjectCV.Controllers
{
    public class HomeController : Controller    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}

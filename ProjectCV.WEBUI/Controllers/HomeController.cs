using Microsoft.AspNetCore.Mvc;
using ProjectCV.BLL;
using System.Threading.Tasks;

namespace ProjectCV.Controllers
{
    public class HomeController : Controller    {
        
        private readonly HttpClient client = new HttpClient();
        public async Task<IActionResult> Index()
        {
            HttpResponseMessage response = await client.GetAsync("https://localhost:7201/api/Skills");
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Task16WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(string x)
        {
            return View();
        }
    }
}

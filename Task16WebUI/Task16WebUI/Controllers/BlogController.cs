using Microsoft.AspNetCore.Mvc;

namespace Task16WebUI.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BlogDetails()
        {
            return View();
        }
    }
}

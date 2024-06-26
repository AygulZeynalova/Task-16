using Microsoft.AspNetCore.Mvc;

namespace Task16WebUI.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            return View();
        }
        public IActionResult Basket()
        {
            return View();
        }
        public IActionResult CheckOut()
        {
            return View();
        }
    }
}

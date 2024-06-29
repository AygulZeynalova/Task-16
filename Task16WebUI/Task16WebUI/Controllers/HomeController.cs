using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Task16WebUI.Models.Contexts;
using Task16WebUI.Models.Entities;

namespace Task16WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext db;

        public HomeController(DataContext db)
        {
            this.db=db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(string fullname, string email, string message)
        {
            var post= new ContactPost {
                FullName=fullname,
                Email = email, 
                Message = message,
                CreatedAt=DateTime.Now
            };

            db.ContactPosts.Add(post);
            db.SaveChanges();
            return Json(new
            {
                error=false,
                message="Your request has been accepted! We will answer you within 2 business days."
            });
        }
      
       
        [HttpPost]
        public IActionResult Subscribe(string email)
        {
            var post = new Subscribe { Email=email };
            db.Subscribes.Add(post);
            db.SaveChanges();
            return Json(new
            {
                error = false,
                message = $"{email}Your request has been accepted"
            });
        }

    }
}

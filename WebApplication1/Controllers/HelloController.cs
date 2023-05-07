using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Student()
        {
            Student student = new Student
            {
                Id = 1,
                Name = "Prasad",
                Gender = "Male"
            };

            return View(student);
         }

    }
}

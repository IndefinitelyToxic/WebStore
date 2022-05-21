using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //return Content("Hello from my first controller");

        }
        public IActionResult Greetings(string? id)
        {
            return Content($"Hello from my first controller - {id}");
        }
    }
}

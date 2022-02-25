using Microsoft.AspNetCore.Mvc;

namespace ohms.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

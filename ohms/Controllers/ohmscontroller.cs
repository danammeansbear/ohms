using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ohmscontroller.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CalculateOhmValue(string bandAColor,string bandBColor, string bandCColor, string bandDColor)
        {
            ViewData["bandAMessage"] = "Current Color of band A is : " + bandAColor;
            ViewData["bandBMessage"] = "Current Color of band B is : " + bandBColor;
            ViewData["bandCMessage"] = "Current Color of band C is : " + bandCColor;
            ViewData["bandDMessage"] = "Current Color of band D is : " + bandDColor;


            return View();
        }
    }
}
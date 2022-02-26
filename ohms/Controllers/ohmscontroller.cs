using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ohmsController.Controllers
{
    public class ohmsController : Controller
    {
        // 
        // GET: /ohms/
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /ohms/CalculateOhmValue
        public IActionResult CalculateOhmValue(string bandAColor,string bandBColor, string bandCColor, string bandDColor,int numTimes = 1)
        {
            ViewData["bandAMessage"] = "Current Color of band A is : " + bandAColor;
            ViewData["bandBMessage"] = "Current Color of band B is : " + bandBColor;
            ViewData["bandCMessage"] = "Current Color of band C is : " + bandCColor;
            ViewData["bandDMessage"] = "Current Color of band D is : " + bandDColor;
            ViewData["NumTimes"] = numTimes;
            //https://localhost:7143/HelloWorld/CalculateOhmValue?bandAColor=red&bandBColor=blue&bandCColor=brown&bandDColor=green&numTimes=4

            return View();
        }
    }
}
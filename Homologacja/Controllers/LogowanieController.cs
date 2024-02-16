using Microsoft.AspNetCore.Mvc;

namespace Homologacja.Controllers
{
    public class LogowanieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Remember_Password()
        {
            return View();
        }
    }
}

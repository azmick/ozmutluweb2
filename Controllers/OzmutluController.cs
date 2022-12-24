using Microsoft.AspNetCore.Mvc;

namespace ozmutluweb.Controllers
{
    public class OzmutluController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About() 
        {
            return View();
        }

        public IActionResult Urunler()
        {
            return View();
        }
    }
}

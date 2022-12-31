using Microsoft.AspNetCore.Mvc;
using ozmutluweb.Models.Siniflar;

namespace ozmutluweb.Controllers
{
    public class OzmutluController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Urunlers.ToList();
            return View(degerler);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}

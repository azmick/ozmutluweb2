using Microsoft.AspNetCore.Mvc;
using ozmutluweb.Models.Siniflar;

namespace ozmutluweb.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Urunlers.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniUrun() //Bunlardan bir tanesi httpgette çalışağı için aynı metottan iki tane oluşturuyoruz.
        {
            return View(); //Sayfa yüklenince hiçbir şey yapma sayfanın bos halini döndür
        }

        [HttpPost]
        public IActionResult YeniUrun(Urunler u)
        {
            c.Urunlers.Add(u);
            c.SaveChanges(); //C# executenonquery mantığı
            return RedirectToAction("Index"); //Sayfada bir şey gönderdiğim zaman buradaki işlemleri döndür.
        }
    }
}

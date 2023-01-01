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

        public IActionResult UrunSil(int id) 
        {
            var u = c.Urunlers.Find(id);
            c.Urunlers.Remove(u);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UrunGetir(int id)
        {
            var ur = c.Urunlers.Find(id);
            return View("Urungetir",ur);
        }

        public IActionResult UrunGuncelle(Urunler u) 
        {
            var uru=c.Urunlers.Find(u.ID);
            uru.Baslik = u.Baslik;
            uru.UrunImage = u.UrunImage;
            uru.Aciklama = u.Aciklama;
            uru.Tarih = u.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

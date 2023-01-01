using Microsoft.AspNetCore.Mvc;
using ozmutluweb.Models.Siniflar;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace ozmutluweb.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
		[Authorize]
		public IActionResult Index()
        {
            var degerler = c.Urunlers.ToList();
            return View(degerler);
        }

        public IActionResult Yorum()
        {
            var degerler = c.Yorumlars.ToList();
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

        [HttpGet]
        public IActionResult YeniYorum() //Bunlardan bir tanesi httpgette çalışağı için aynı metottan iki tane oluşturuyoruz.
        {
            return View(); //Sayfa yüklenince hiçbir şey yapma sayfanın bos halini döndür
        }

        [HttpPost]
        public IActionResult YeniYorum(Yorumlars y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges(); //C# executenonquery mantığı
            return RedirectToAction("Yorum"); //Sayfada bir şey gönderdiğim zaman buradaki işlemleri döndür.
        }


        public IActionResult YorumGetir(int id)
        {
            var ur = c.Yorumlars.Find(id);
            return View("Yorum", ur);
        }

        public IActionResult YorumGuncelle(Yorumlars y)
        {
            var uru = c.Yorumlars.Find(y.ID);
            uru.ID = y.ID;
            uru.KullaniciAdi = y.KullaniciAdi;
            uru.Yorum= y.Yorum;
            uru.Mail = y.Mail;
            uru.Urunlerid = y.Urunlerid;
            c.SaveChanges();
            return RedirectToAction("Yorum");
        }

        public IActionResult YorumSil(int id)
        {
            var ys = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(ys);
            c.SaveChanges();
            return RedirectToAction("Yorum");
        }

        public async Task<IActionResult> LogOut() 
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login","Access");
        
        }


    }
}

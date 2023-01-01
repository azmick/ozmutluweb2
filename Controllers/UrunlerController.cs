using Microsoft.AspNetCore.Mvc;
using ozmutluweb.Models.Siniflar;

namespace ozmutluweb.Controllers
{
	public class UrunlerController : Controller
	{
		Context c = new Context();
        UrunYorum uy = new UrunYorum();
        public IActionResult Index()
		{
			//var ürünler = c.Urunlers.ToList();
			uy.Deger1 = c.Urunlers.ToList();
			uy.Deger3 = c.Urunlers.OrderByDescending(x=>x.ID).Take(3).ToList();
			return View(uy);
		}
		public IActionResult UrunlerDetay(int id)
		{
            
            //var blogbul = c.Urunlers.Where(x => x.ID == id).ToList();
            uy.Deger1 = c.Urunlers.Where(x => x.ID == id).ToList();
			uy.Deger2 = c.Yorumlars.Where(x => x.Urunlerid == id).ToList() ;
			return View(uy);
		}
		[HttpGet]
		public PartialViewResult YorumYap() 
		{ 
            return PartialView();
		}

		[HttpPost]
		public PartialViewResult YorumYap(Yorumlars y) 
		{
			c.Yorumlars.Add(y);
			c.SaveChanges();
			return PartialView();
		}

	}
}

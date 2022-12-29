using Microsoft.AspNetCore.Mvc;
using ozmutluweb.Models.Siniflar;

namespace ozmutluweb.Controllers
{
	public class UrunlerController : Controller
	{
		Context c = new Context();
		public IActionResult Index()
		{
			var ürünler = c.Urunlers.ToList();
			return View(ürünler);
		}

		public IActionResult UrunlerDetay(int ID) 
		{
			return View();
		}
	}
}

using Microsoft.AspNetCore.Mvc;

namespace ozmutluweb.Controllers
{
	public class UrunlerController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

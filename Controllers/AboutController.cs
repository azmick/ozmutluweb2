using Microsoft.AspNetCore.Mvc;
using ozmutluweb.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Web;


namespace ozmutluweb.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}

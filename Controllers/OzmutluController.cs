﻿using Microsoft.AspNetCore.Mvc;

namespace ozmutluweb.Controllers
{
    public class OzmutluController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

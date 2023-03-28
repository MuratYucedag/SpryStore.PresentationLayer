using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpryStore.PresentationLayer.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 100);
            ViewBag.n = 25;
            return View();
        }
    }
}

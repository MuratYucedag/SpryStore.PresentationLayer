using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpryStore.PresentationLayer.Areas.Catalog.Controllers
{
    [Area("Catalog")]
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialAboutCover()
        {
            return PartialView();
        }
        public PartialViewResult PartialAboutWhatWeDo()
        {
            return PartialView();
        }
    }
}

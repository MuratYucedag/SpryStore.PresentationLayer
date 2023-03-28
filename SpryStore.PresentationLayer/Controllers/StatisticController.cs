using Microsoft.AspNetCore.Mvc;
using SpryStore.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpryStore.PresentationLayer.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            Context context = new Context();
            ViewBag.categoryCount = context.Categories.Count();
            ViewBag.productCount = context.Products.Count();
            ViewBag.productCountByElectronic = context.Products.Where(x => x.Category.CategoryName == "Elektronik").Count();
            ViewBag.priceUnder5000 = context.Products.Where(x => x.Price <= 5000).Count();
            ViewBag.avgPrice = context.Products.Average(x => x.Price);
            return View();
        }
    }
}

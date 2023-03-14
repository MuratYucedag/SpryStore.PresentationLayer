using Microsoft.AspNetCore.Mvc;
using SpryStore.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpryStore.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Customers.ToList();
            return View(values);
        }
    }
}

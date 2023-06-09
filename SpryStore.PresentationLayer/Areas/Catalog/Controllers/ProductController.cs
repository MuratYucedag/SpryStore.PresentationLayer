﻿using Microsoft.AspNetCore.Mvc;
using SpryStore.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpryStore.PresentationLayer.Areas.Catalog.Controllers
{
    [Area("Catalog")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var values = _productService.TGetProductListWithCategory();
            return View(values);
        }
    }
}

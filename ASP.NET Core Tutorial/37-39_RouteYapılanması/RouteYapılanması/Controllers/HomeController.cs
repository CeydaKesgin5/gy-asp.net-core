﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RouteYapılanması.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RouteYapılanması.Controllers
{
    //Attribute Routing
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("[action]")]// home/index
        [Route("in/{id?}")] //özelleştiriledebilir -> home/in

        public IActionResult Index(int? id)
        {
            return View();
        }
        [Route("[action]")] // home/privacy

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

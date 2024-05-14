using IoC.Models;
using IoC.Services;
using IoC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IoC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        #region controller bazlı talep
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        //readonly ILog _log;

        //public HomeController(ILog log)
        //{
        //    _log = log;
        //}
        #endregion
        #region Action bazlı talep
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        readonly ILog _log;

        public HomeController([FromServices]ILog log)
        {
            _log = log;
        }
        #endregion

        public IActionResult Index()
        {
            _log.Log();
           // TestLog log = new TestLog();
            //ConsoleLog log = new ConsoleLog();
            //log.Log();

            return View();
        }

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

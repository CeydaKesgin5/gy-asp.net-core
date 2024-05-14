using Microsoft.AspNetCore.Mvc;

namespace Area.Areas.fatura_paneli.Controllers
{
    public class HomeController : Controller
    {
        [Area("faturaYonetim")]
        public IActionResult Index()
        {
            var data = TempData["data"];
            return View();
        }
    }
}

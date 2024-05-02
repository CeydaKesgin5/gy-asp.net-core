using Microsoft.AspNetCore.Mvc;

namespace _14_İlk_uygulama.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Area.Areas.Yonetim_paneli.Controllers
{
    [Area("yonetimPaneli")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            #region Arealar arası veri taşıma
            TempData["data"] = "sebepsiz boş yere ayrılacaksan....";
            return RedirectToAction("Index", "Home", new {area= "faturaYonetim" });
            #endregion
            
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace _17_View.Controllers
{
    public class ModelBindingController : Controller
{
    public IActionResult GetProducts()
    {
        return View();
    }
        public IActionResult CreateProducts()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProducts(object x)
        {
            return View();
        }
    }
}

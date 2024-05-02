using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _17_View.Controllers
{
    public class VeriAlmaController : Controller
{
        [HttpPost]
        //public IActionResult VeriAlma(IFormCollection datas)//veri yakalama
        //{

        //        var value1 = datas["txtvalue1"].ToString();
        //        var value2 = datas["txtvalue2"];
        //        var value3 = datas["txtvalue3"];
        //    return View();
        //}

        public IActionResult VeriAlma( string txtvalue1, string txtvalue2, string txtvalue3)//veri yakalama
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace VeriAlmaYöntemleri.Controllers
{
    public class AjaxData
    {
        public string A { get; set; }
        public string B { get; set; }

    }
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            return View();
        }
        public IActionResult CreateProducts()
        {
            return View();
        }

        #region Query String
        //public IActionResult VeriAl(string a, string b)

        #region Request.QueryString
        //public IActionResult VeriAl()
        //{
        //    var queryString= Request.QueryString;
        //    //Request yapılan endpointte query string parametresi eklenmiş mi eklenmemiş mi bunula ilgili bilgi verir

        //    var a= Request.Query["a"].ToString();
        //    var b= Request.Query["b"].ToString();



        //    return View();
        //}
        #endregion


        #region QueryData gibi ayrı bir fonksiyonla değişken tanımlama
        //public class QueryData
        //{
        //    public int A { get; set; }
        //    public int B { get; set; }
        //}
        //public IActionResult VeriAl(QueryData data)
        //{
        //    return View();
        //}
        #endregion

        /* Query string: Güvenlik gerektirmeyen bilgilerin url üzerinde taşınması için kullanılan yapılanmadır.
         https://.......com/sehir/ankara?ilce=2 açık veri gerektirmeyen veri
         */

        //yapılan requestin türü her ne olursa olsun query string değerleri taşınabilir.
        #endregion

        #region Route
        #region Request.RouteValues
  public IActionResult VeriAl(object id)//önemli olan parameterenin ismi(id)
        {
            var values= Request.RouteValues;//Values de 3 parametre okunuyor 0: controller 1:action 2:id
            return View();  
        }
        #endregion
      

       public class RouteData
        {
            public int A { get; set; }
           public string B { get; set; }
            public string Id { get; set; }

        }
       // public IActionResult VeriAl(string id, int a, string b)

        public IActionResult VeriAl(RouteData datas)
        {
            var values = Request.RouteValues;//Values de 3 parametre okunuyor 0: controller 1:action 2:id
            return View();
        }
        #endregion

        //route gizli, query string açık veri taşır

        #region Header
        #region Request.Headers 
        //public IActionResult VeriAl()
        //{
        //    var headers = Request.Headers;//Values de 3 parametre okunuyor 0: controller 1:action 2:id
        //    return View();
        //}

        #endregion
        #endregion


        #region Ajax Tabanlı Veri Alma

        //client tabanlı istek yapmamızı ve bu istek sonuçlarını almamızı sağlayan bir js temelli mimari
     

        [HttpPost]
        public IActionResult VeriAl(AjaxData ajaxData)
        {
            return View();
        }


        #endregion
    }
}

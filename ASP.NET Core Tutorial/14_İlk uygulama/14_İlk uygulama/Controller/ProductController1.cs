using Microsoft.AspNetCore.Mvc;

namespace _14_İlk_uygulama.Controller
{
    //[NonController]
    public class ProductController1 : Controller
    {
        //Controllerin temel amacı gelen requestleri karşılamaktır.
        //Controller içinde iş mantıkları olmamalıdır, başka sınıflarda olur
        //Controller response çin gerekli yönlendirmeyi/organizasyonu sağlar.

        public IActionResult actionResult()
        {
            X();
            return View();
        }
        [NonAction]
        public void X() //NonAction attribute i ile işaretlenen fonksiyon artık action fonksiyonu yani response döndürecek fonksiyon değildir. 
        //Yani dışarıdan istek almaz, algoritmiş içinde iş mantığı olan bir fonksiyondur.
        {

        }
        #region ViewResult  
        //  public ViewResult GetProducts()
        // {
        //     return View();
        // }
        #endregion

        #region PartialViewResult  
        //View dosyasını render etmemizi sağlayan bir action türüdür.
        //ViewResult'tan temel farkı, client tabanlı yapılan Ajax isteklerinde kullanıma yatkın olmasıdır.
        //Teknik fark ise ViewResult_ViewState.cshtml dosyasını baz alır. PartialViewResult ise ilgili dosyayı baz alamdan render edilir.

        //  public PartialViewResult GetProducts()
        // {
        //   PatialViewResult result=  PatialView();
        //     return result;
        // }
        #endregion

        #region JsonResult
        //Üretilen datayı JSON türüne dönüştürüp döndüren bir action türüdür.
        //Genelde ajax tabanlı projelerde tercih edilir.

        //public JsonResult GetProducts()
        //{
        //    JsonResult result=JsonResult(new Product){
        //            Id=5,
        //            ProductName="Terlik",
        //            Quantity=15
        //    });
        //    return result ;

        //}
        #endregion

        #region EmptyResult
        //public EmptyResult GetProducts()
        //{
        //    return new EmptyResult();
        //}
        #endregion

        #region ContentResult
        //İstek neticesinde cevap olarak metinsel değer döndürür.
        //Genelde ajax tabanlı projelerde tercih edilir.


        //public ContentResult GetProducts()
        //{
        //    ContentResult result = Content("ceyda");
        //    return result;
        //}
        #endregion

        #region ActionResult
        //Gelen istek neticesinde geriye döndürülecek action türleri değişkenlik gösterebildiği durumlarda kullanılır.

        //public ActionResult GetProducts()
        //{
        //    if (true)
        //    {
        //        //...
        //        return Json(new object());
        //    }
        //    else if (true)
        //    {
        //        return Content("hgcyftuygıhu");
        //    }
        //    return View();
        //}
        #endregion


    }
}

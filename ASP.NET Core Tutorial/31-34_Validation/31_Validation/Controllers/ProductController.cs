using _31_Validation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace _31_Validation.Controllers
{
    public class ProductController : Controller
    {
        /*
         Validation: Bir degerin icinde bulundugu sartlara uygun olmasi durumudur. Belirlenen kosullara ve amaca uygun olup olmama durumunun kontrol edilmesidir
         Bu kontrolere gore verinin isleme tabi tutulmasi durumudur
         Validation paralel bir şekilde server ve client taraflarında uygulanmalıdır.
         
         */
        public IActionResult GetProducts()
        {
            return View();
        }
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct( Product model)
        {
           //ModelState: MVC'de bir type'in data annotationsların durumunu kontrol eden ve geriye sonuç dönen bir property.
           if(!ModelState.IsValid)
            {
                //loglama,kullanıcı bilgilendirme,uyarı

                // ViewBag.HataMesaj = ModelState.Values.FirstOrDefault(x=>x.ValidationState==Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid).Errors[0].ErrorMessage;

                // return null;

                var messages = ModelState.ToList();

                //asp-validation-for kullanılıdğında
                return View(model);
            }

            //işlem/operasyon/algoritmaya tabi tutulur





            return View();
        }
    }
}

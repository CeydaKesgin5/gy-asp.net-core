using _17_View.Models;
using _17_View.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
//using Microsoft.AspNetCore.Mvc;

namespace _17_View.Controllers
{
    public class ProductController : Controller
    {/*
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product{ Id=1, ProductName="A Product", Quantity=10},
                new Product{ Id=2, ProductName="B Product", Quantity=10}, 
                new Product{ Id=3, ProductName="C Product", Quantity=10}

            };
            #region Model Bazlı Veri Gönderimi
            // return View(products);
            //cshtml dosyasında view e taşındı.
            #endregion

            #region Veri Taşıma Kontrolleri
            #region ViewBag
            //View'e gönderilecek/taşınacak datayı dynamic şekilde tanımlanan bir değişkenle taşımamızı sağlayan bir veri taşıma kontrolüdür.
            //ViewBag.products = products;

            #endregion

            #region ViewData
            //ViewBag'da olduğu gibi actiondaki datayı viewe taşımamızı sağlayan bir kontroldür.
            ViewData["products"] = products;
            #endregion
            #region TempData
            //ViewData'da olduğu gibi actiondaki datayı viewe taşımamızı sağlayan bir kontroldür.
            //cookie üzerinden verileri taşıyor.
            TempData["products" ]= products;


            TempData["x"] = 5;
            ViewBag.x = 5;
            ViewData["x"] = 5;


            #endregion
            #endregion
            return RedirectToAction("Index2","Product");

        }
        public IActionResult Index2()
        {
            var v1 = ViewBag.x;//taşımamış
            var v2 = ViewData["x"];//taşımamış
            var v3 = TempData["x"];//actionlar arasında veri taşımamızı sağlayan bir veri taşıma kontrolü 
            return View();
        }*/

        public IActionResult GetProducts()
        {
            Product product = new Product {
                Id = 1,
                ProductName = "A Product",
                Quantity = 15

            };
            User user = new User()
            {
                Id = 1,
                Name = "Ceyda",
                LastName = "Yıldız"

            };

            //UserProduct userProduct = new UserProduct
            //{
            //    User = user,
            //    Product = product,
            //};

            //tuple
            var userProduct = (product, user );
                return View(userProduct);



        }
    } 
}

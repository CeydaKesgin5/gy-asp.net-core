using _44_ViewModel.Business;
using _44_ViewModel.Models;
using _44_ViewModel.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _44_ViewModel.Controllers
{
    public class PersonelController : Controller
    {
        public IMapper Mapper { get; set; }
        public PersonelController(IMapper mapper) { }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PersonelCreateVM personelCreateVM)
        {
            #region Manuel Dönüştürme
            //Personel p = new Personel()
            //{
            //    Name = personelCreateVM.Name,
            //    Surname = personelCreateVM.Surname,
            //};
            #endregion
            #region Implicit
            //Personel personel = personelCreateVM;
            // PersonelCreateVM vm = personel;
            #endregion
            #region Explicit/ bilinçli bir şekilde tanımlamamız lazım
            //Personel p = (Personel)personelCreateVM;
            //PersonelCreateVM p2=(PersonelCreateVM)p;
            #endregion
            #region Reflection
            //Personel p = TypeConversion.Conversion<PersonelCreateVM, Personel>
            //    (personelCreateVM);

            //PersonelListeVM personelListeVM= TypeConversion.Conversion<Personel, PersonelListeVM>(new Personel { Name = "ceyda", Surname = "kesgin" });
            #endregion
            #region AutoMapper Kütüphanesi
           Personel p= Mapper.Map<Personel>(personelCreateVM);
           PersonelCreateVM p2 = Mapper.Map<PersonelCreateVM>(p);

            #endregion
            //...
            return View();
        }


        public IActionResult Listele()
        {
            List<PersonelListeVM> personeller = new List<Personel>
            {
                new Personel{Name="A",Surname="B"},
                new Personel{Name="A1",Surname="B"},
                new Personel{Name="A2",Surname="B"},
                new Personel{Name="A3",Surname="B"},
                new Personel{Name="A4",Surname="B"},
                new Personel{Name="A5",Surname="B"}

            }.Select(p => new PersonelListeVM
            {
                Name = p.Name,
                Surname = p.Surname,
                Position = p.Position,
            }).ToList();

            return View(personeller);

            //best practice açısından hiçbir zaman veritabnından gelen datalar direkt olarak ilgili viewlere,clientlere gönderilmez.



        }
        public IActionResult Get()
        {
            var nesne = (new Personel(), new Urun(), new Musteri());
            return View();
        }

        #region ViewModel'ı Entity Model'e dönüştürme
        //Kullanıcıdan gelen dataları ViewModel ile karşıladıktan sonra ViewModel'deki verileri veritabanına kaydetmek isteyebiliriz. Bu durumda verileri Entity Model'a dönüştürmemiz gerekebilir.
        /* Yöntemler
         *      Manuel
         *      Implicit Operator Overload ile
         *      Explicit Operator Overload ile
         *      Reflection ile
         *      AutoMapper Kütüphanesi ile
         
         */
        #endregion

    }

}

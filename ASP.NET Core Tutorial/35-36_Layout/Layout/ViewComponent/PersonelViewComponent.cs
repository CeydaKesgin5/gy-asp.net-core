using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Layout.ViewComponent
{
    public class PersonelViewComponent : ViewComponent
    {
        /*
         Tasarlanan ViewComponent çağırılıp render edildiğinde içerisinde çalışmasını istediğimiz kodları bu imzsda bir metodun içerisine yerleştirmeliyiz.
         */
        public IViewComponentResult Invoke()//Invoke olmalı,farklı bir isim kullanılamaz.
        {
            return View();

        }
        //Component Controller gibi çalışamamakta, sadece get operasyonlarına cevap verebilir.
    }
}

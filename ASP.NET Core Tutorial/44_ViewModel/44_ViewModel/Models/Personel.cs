using _44_ViewModel.Models.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace _44_ViewModel.Models
{
    //entity model
    public class Personel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required]
        [StringLength(13)]
        public string Position { get; set; }
        public int  salary { get;}
        public int state { get;}

        #region Implicit Dönüştürme/Gizli/Bilinçsiz tür dönüşümü
        //herhangi bir sınıfta dönüşüm yapılabilir
        ////PersonelCreateVM'ı Personele dönüştürdük
        //public static implicit operator PersonelCreateVM(Personel model)
        //{
        //    return new PersonelCreateVM
        //    {
        //        Name = model.Name,
        //        Surname = model.Surname,
        //    };
        //}
        ////Personele'ı PersonelCreateVM'e dönüştürdük
        //public static implicit operator Personel(PersonelCreateVM model)
        //{
        //    return new Personel
        //    {
        //        Name = model.Name,
        //        Surname = model.Surname
        //    };
        //}
        #endregion

        #region Explicit/Açık/ilinçli
        public static explicit operator PersonelCreateVM(Personel model)
        {
            return new PersonelCreateVM
            {
                Name = model.Name,
                Surname = model.Surname,
            };
        }
        //Personele'ı PersonelCreateVM'e dönüştürdük
        public static explicit operator Personel(PersonelCreateVM model)
        {
            return new Personel
            {
                Name = model.Name,
                Surname = model.Surname
            };
        }
        #endregion
    }
}

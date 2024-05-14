namespace _44_ViewModel.Models.ViewModels
{
    public class XVM
    {
        public Personel Personel { get; set; }
        public Urun Urun { get; set; }
        public Musteri Musteri { get; set; }


        #region Validation

        /*
         Kullanıcılardan gelen veriler kesinlikle veritabanı tablolarının karşılığı olan entity modelleri olmamalıdır.
        Viewmodel olarak alınmalıdır.
        Ve tüm validationlar bu ViewModel nesneleri üzerinde gerçekleştirilmelidir.
         */
        #endregion
    }
}

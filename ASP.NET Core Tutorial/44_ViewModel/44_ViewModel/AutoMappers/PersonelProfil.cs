using _44_ViewModel.Models;
using _44_ViewModel.Models.ViewModels;
using AutoMapper;

namespace _44_ViewModel.AutoMappers
{
    public class PersonelProfil : Profile
    {
        public PersonelProfil(){ 
            CreateMap<Personel,PersonelCreateVM> ();//personeli personelcreatevm ye dönüştür.
            CreateMap<PersonelCreateVM, Personel>();
        }
    }
}

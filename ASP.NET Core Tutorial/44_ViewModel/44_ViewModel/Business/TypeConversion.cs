using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Reflection;

namespace _44_ViewModel.Business
{
    public static class TypeConversion
    {
        public static TResult Conversion<T,TResult>(T model) where TResult : class,new()//TResult nesne üretebilen bir class olduğnu belirttik
        {
            TResult result=new TResult();
            typeof(T).GetProperties().ToList().ForEach(p =>
            {
                PropertyInfo property = typeof(TResult).GetProperty(p.Name);
                property.SetValue(result,p.GetValue(model));//resulta p'nin modeldak değeri geldi
            }
                );

            return result;
        }
    }
}

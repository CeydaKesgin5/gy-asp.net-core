using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14_İlk_uygulama
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();//Asp.Net core uygulamasında MVC mimarisini kullanabailmek için Controller ve Views yapılanmalarının eklenmesi gerekmektedir
                                               //Onun için öncelikle bu servis eklendi. Böylece uygualama mvc davranışı sergileyebilecektir.
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();//Gelen isteğin rotası bu middleware sayesinde belirlenir.

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
                endpoints.MapDefaultControllerRoute();
                //{controller=Home}/{action=Index}/{id?} -> Default olan endpoint şeması
                //Bu uygulamaya yapılacak olsan istekler bu şemeya uygun şekilde yapılacaktır
                // https://www....com/personel/getir
            });
            //Endpoint: Yapılan isteğin varış noktası -> Url,İSTEK ADRESİ
            //Bu uygulamaya gelen isteklerin hagi rotalar eşliğinde gelebileceğini buradan bildireceğiz.



        }
    }
}

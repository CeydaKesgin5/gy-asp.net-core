using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RouteYapılanması.Constrait;
using RouteYapılanması.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RouteYapılanması
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RouteOptions>(options => options.ConstraintMap.Add("custom", typeof(CustomConstrait)));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();//Gelen rotayı ayrıştırır.

            app.UseAuthorization();
            //UseEnpoints middleware'i kendi içinde rotaları tutan,tarif etmemizi sağlayan bir yapılanma

            //rotaları tanımlar
            app.UseEndpoints(endpoints =>
            {
                //Birden fazla rota oluşturulduğunda özelden genele sıralanmalıdır.

                //default dışında customize edilmiş rotalar oluşturmamızı sağlar.
                //Her bir Controller Route'un ismi olmalı ve unique olmalı
               
                //endpoints.MapControllerRoute("Default1", "{ controller=Home}/{action=index}");
                //endpoints.MapControllerRoute("Default2", "{action}/ceyda/{controller}");//özelleştirilebilir.
                //endpoints.MapControllerRoute("Default3", "anasayfa",new {controller= "Home", action= "Index" }); //isimlendirilebilir.

                //endpoints.MapControllerRoute("Default4", "{controller=Home}/{actiın=Index}/{id?}/{x?}/{y?}");

                //Custom Constrait
                //endpoints.MapControllerRoute("Default5", "{controller=Home}/{actiın=Index}/{id:custom}/{x:alpha:length(12)?}/{y:int?}"); //sınırlandırılabilir

                //endpoints.MapDefaultControllerRoute();//otomatik ön tanımlı rota getirir
                
                //{controller=home}/{action=Index}/{id?}
                //Default olarak home ve index tetiklenir, o yüzden alttaki cevapların hepsi home,index!e gider.
                //   /
                //   /home
                //   /Home/index   hepsinde aynı rota tetiklenir.

                endpoints.MapControllers();//Controller'dan gelen isteği Controller'daki route ile eşleştir.
            });
        }
    }
}

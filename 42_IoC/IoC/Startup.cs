using IoC.Services;
using IoC.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
           // services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog()));
           //  services.Add(new ServiceDescriptor(typeof(TestLog), new TestLog()));//Default olarak singleton, add fonksiyonuyla eklendi�i i�in

            services.AddSingleton<ConsoleLog>();//ConsoleLog t�r�nden nesne al,istek geldi�inde �ret ve g�nder

            #region Containere eklenen nesnenin constructoru parametreli ise
            //Containere eklenen nesnenin constructoru parametreli ise
            services.AddSingleton<ConsoleLog>(p => new ConsoleLog(5));

            services.AddScoped<ConsoleLog>();
            services.AddScoped(p => new ConsoleLog(10));

            services.AddTransient<ConsoleLog>();
            services.AddTransient<ConsoleLog>(p => new ConsoleLog(20));
            #endregion

            #region Nesne Bildirimlerinde Uyulmas� Gereken Abstraction Mant���

            //services.AddScoped<ILog>(p=>new ConsoleLog(30));
            services.AddScoped<ILog, TestLog>();//Hangi aray�z�n olaca��n� ve hang, nesneden al�naca�� bildirildi
            #endregion

            #region Controller Constructor'undan Nesne Talebinde Nas�l Bulunulur?

            #endregion
            services.AddControllersWithViews();
        }

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

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

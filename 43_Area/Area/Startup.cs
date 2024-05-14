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

namespace Area
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
                #region MapControllerRoute
                //endpoints.MapControllerRoute(
                //    name: "areaDefault",
                //    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id}"
                //    );
                //exists: Route'un bir area ile eþleþmesi için kýsýtlama uygular.

                //yonetimPaneli area deðerine sahip olan controllerlar aþaðýdaki route den deðer alabileceklerdir.

                #endregion

                #region MapAreaControllerRoute
                endpoints.MapAreaControllerRoute(
                  name: "yonetim",
                  areaName: "yonetimPaneli",
                  pattern: "admin/{controller=Home}/{action=Index}");

                endpoints.MapAreaControllerRoute(
                    name: "fatura",
                    areaName: "faturaYonetim",
                    pattern: "fatura/{controller=Home}/{action=Index}");

                #endregion

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            #region Arealar arasý baðlantý oluþturma
            //Taghelper ve htmlhelper ile baðlantý kurulabilir.

            #region TagHelper

            /*
             <a asp-action="Index" asp-controller="Home" asp-area="yonetim"> Yonetim</a>
             */

            #endregion
            #region HtmlHelper
            /*
            @Html.ActionLink("Yonetim","Index","Home", new {area="Yonetim"})
           <a href ="@Url.Action("Index","Controller",new{area="yonetim})" >Yonetim</a>

            */
            #endregion


            #endregion

            

        }
    }
}

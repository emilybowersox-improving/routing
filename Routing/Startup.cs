using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Routing
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

            app.UseRouting();

            app.UseAuthorization();



            app.UseEndpoints(endpoints =>
            {
                /*            endpoints.MapControllerRoute(
                                name: "websiteone",
                                pattern: "watch",
                                defaults: new { controller = "Home", action = "WebsiteOne" });


                            endpoints.MapControllerRoute(
                                name: "websitetwo",
                                pattern: "/gp/buyagain",
                                defaults: new { controller = "Home", action = "WebsiteTwo" });


                            endpoints.MapControllerRoute(
                                name: "websitethree",
                                pattern: "/HighKey-Snacks-Keto-Mini-Cookies/dp/B07JYS45BT",
                                defaults: new { controller = "Home", action = "WebsiteThree" });*/



                /*                endpoints.MapControllerRoute(
                                name: "generic query string route",
                                pattern: "/{pattern}{query}",
                                defaults: new { Controller = "Home", action = "GenericQueryRoute" });*/

                endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}");

                endpoints.MapControllerRoute(
                name: "generic query string route",
                pattern: "/{stringOne?}/{stringTwo?}/{stringThree?}/{stringFour?}/{stringFive?}/{stringSix?}",
                defaults: new { Controller = "Home", action = "GenericRoute" });


/*
                endpoints.MapControllerRoute(
               name: "default",
               pattern: "{controller=Home}/{action=Index}/{id?}");*/



            });
        }
    }
}

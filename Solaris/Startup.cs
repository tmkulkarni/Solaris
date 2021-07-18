using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Reflection;
//using Solaris.Data;

namespace Solaris
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        //public IConfiguration Configuration { get; }

        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}








        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = true);

            //services.AddDbContext<MasterContext>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("MasterContext")));
            //  services.AddRazorPages();
            // services.AddControllersWithViews();



            //services.AddDbContext<AppContext>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
           
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                 "default",
                  "{controller=Home}/{action=Index}/{id?}");
             //  endpoints.MapRazorPages();
            });
            //app.UseEndpoints(routes =>
            //{
            //    routes.MapControllerRoute(
            //  name: "default",
            //   "{controller=Home}/{action=Index}/{id?}");
            //});
        }

      


    }
}

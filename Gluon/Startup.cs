using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gluon.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Gluon
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddTransient<PortfolioServiceJsonFile>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Add Middleware: must come before UseRouting.
            app.UseStaticFiles(); //Ã“IHTML, CSS, JS.... ‚ðŽÀs
            // app.UseFileServer(); //Šî–{•¶‘“o˜^

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!!!");
                //});
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AVI_IT
{
    public class Startup
    {
        private readonly IConfigurationRoot configuration;

        public Startup(IWebHostEnvironment env)
        {
            configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables().AddJsonFile(env.ContentRootPath + "/config.json")
                .Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Startup config = new Startup(env);

            if (config.configuration.GetValue<bool>("EnableDeveloperExceptions"))
            {
                app.UseDeveloperExceptionPage();
            }
            else
                app.UseExceptionHandler("/error.html");

            app.Use(async (context, next) =>
            {
                
                await next();
            });


            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Quotation}/{action=Index}/{id?}");
            });

            app.UseFileServer();
        }
    }
}

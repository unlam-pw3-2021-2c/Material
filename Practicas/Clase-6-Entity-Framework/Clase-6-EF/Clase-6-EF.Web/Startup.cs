using Clase_6_EF.Data.EF;
using Clase_6_EF.Data.Repositorios;
using Clase_6_EF.Data.Repositorios.Interfaces;
using Clase_6_EF.Servicios;
using Clase_6_EF.Servicios.Interfaces;
using Clase_6_EF.Web.Logic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase_6_EF.Web
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
            services.AddTransient<Db_TiendaContext>();
            services.AddScoped<ILocalRepositorio, LocalRepositorio>();
            services.AddScoped<IPrendaRepositorio, PrendaRepositorio>();
            services.AddScoped<ILocalServicio, LocalServicio>();
            services.AddScoped<IPrendaServicio, PrendaServicio>();
            services.AddScoped<IOperacionesLogic, OperacionesLogic>();

            services.AddControllersWithViews();

            services.AddSession(options =>
                                    options.IdleTimeout = TimeSpan.FromMinutes(10)
                                );
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
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

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Local}/{action=Lista}/{id?}");
            });
        }
    }
}

using ConsultasMVC.dbenersave;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;

namespace ConsultasMVC
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<ITgastosAguaStore, GastosAguaStore>();
            services.AddScoped<ITgastosEnergiaStore, GastosEnergiaStore>();
            services.AddScoped<IDescarteLixoStore, DescarteLixoStore>();
            services.AddScoped<IUsuarioStore, UsuarioStore>();

            //var connection = @"server=localhost;user id=dbenersave;database=dbenersave;password=;port=3306;CHARSET=utf8;convert zero datetime=True;";
            var connection = @"server=localhost;user id=root;database=dbenersave;password=123456;port=3306";
            services.AddDbContext<DbEnerSaveContext>
                (options => options.UseMySql(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            CultureInfo customCulture = new CultureInfo(CultureInfo.CurrentCulture.Name);
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            CultureInfo.DefaultThreadCurrentCulture = customCulture;

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "login",
                    template: "{controller=Login}/{action=Login}");
                routes.MapRoute(
                    name: "gastosAgua",
                    template: "{controller=TgastosAgua}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "gastosEnergia",
                    template: "{controller=TgastosEnergia}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "descarteLixo",
                    template: "{controller=TdescarteLixo}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "usuarios",
                    template: "{controller=Tusuarios}/{action=Index}/{id?}");
            });
        }
    }
}

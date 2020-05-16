using LaboratoryQualityControl.DataAccess;
using LaboratoryQualityControl.Domain;
using LaboratoryQualityControl.Services.BloodControls;
using LaboratoryQualityControl.Services.Devices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace LaboratoryQualityControl
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
            services.AddDbContext<LaboratoryQCContext>(opts =>
            {
                opts.UseSqlServer(Configuration["ConnectionString:LaboratoryQC"]);
            });

            services.AddCors((co) =>
            {
                co.AddPolicy("Test",(cb) =>
                {
                    cb.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().Build();
                });
            });
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IBloodControlService, BloodControlService>();
            services.AddScoped<IDeviceService, DeviceService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                        .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver()); ;
            services.AddSpaStaticFiles(options =>
            {
                options.RootPath = "ClientApp/Build";
            });
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
            app.UseCors("Test");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();
            app.UseCookiePolicy();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}");

            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                //if (env.IsProduction())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}

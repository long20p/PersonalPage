using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PersonalPage.Common.Settings;
using PersonalPage.Persistence.Repositories;
using PersonalPage.Server.Services;
using System.Text;

namespace PersonalPage.Server
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
            services.Configure<DbSettings>(Configuration.GetSection("Mongo"));

            services.AddCors(options =>
            {
                var allowedOrigins = Configuration.GetSection("Cors:AllowedOrigins").Get<string[]>();
                options.AddDefaultPolicy(builder => 
                    builder.WithOrigins(allowedOrigins));
            });

            services.AddControllers();
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddSingleton<IDbContext, DbContext>();
            services.AddTransient<IArticleRepository, ArticleRepository>();
            services.AddTransient<IArticleService, ArticleService>();

            // In production, the Angular files will be served from this directory
            //services.AddSpaStaticFiles(configuration =>
            //{
            //    configuration.RootPath = "ClientApp/dist/PersonalPage";
            //});
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
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseSpaStaticFiles();

            app.UseCors();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/Admin");
            });

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            //app.UseSpa(spa =>
            //{
            //    // To learn more about options for serving an Angular SPA from ASP.NET Core,
            //    // see https://go.microsoft.com/fwlink/?linkid=864501

            //    spa.Options.SourcePath = "ClientApp";

            //    if (env.IsDevelopment())
            //    {
            //        spa.UseAngularCliServer(npmScript: "start");
            //    }
            //});
        }
    }
}

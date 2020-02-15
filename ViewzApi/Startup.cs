using DataAccess.Interfaces;
using DataAccess.MockRepositories;
using DataAccess.Models;
using DataAccess.Repositories;
using DataAccess.APIAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ViewzApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        readonly string AllMyOrigins = "_allMyOrigins";

        // This method gets called by the runtime. Use this method to add services to the container.
        
        public void ConfigureServices(IServiceCollection services)
        {
            //this service initially took empty overload
            services.AddControllers(options =>
            {
                options.RespectBrowserAcceptHeader = true; 
            });

            //ADD CORS
            services.AddCors(options =>
            {
                options.AddPolicy(AllMyOrigins, b => b.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

            services.AddDbContext<ViewzDbContext>(options =>
               options.UseSqlServer(
                   Configuration.GetConnectionString("ViewzDb")));

            services.AddSingleton<IMdToHtmlAndContentsFactory, MdToHtmlAndContentsFactory>();
            //services.AddScoped<IWikirepository, WikiRepository>();
           services.AddScoped<IPageRepository, PageRepositoryRetrieving>();
          //  services.AddScoped<IPageRepository, MockPageRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            //  loggerFactory.AddFile("Logs/mylog-{Date}.txt");
            //USE CORS
            app.UseCors(AllMyOrigins);

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

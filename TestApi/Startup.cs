using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using NSwag;
using NSwag.AspNetCore;
using TestApi.Models;

namespace TestApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration) => Configuration = configuration;
        /*{
            Configuration = configuration;
        }*/

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSwagger();
            services.AddDbContext<ItemsContext>(opt => opt.UseSqlServer(Configuration["Data:CommandAPIConnection:ConnectionString"]));
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseSwaggerUi3WithApiExplorer(settings=> {
                settings.PostProcess = document =>
                {
                    document.Info.Version = "1.0.0";
                    document.Info.Title = "Producst API";
                    document.Info.Description = "API service for online shop";
                    document.Info.TermsOfService = "none";
                };
            });
            app.UseMvc();
        }
    }
}

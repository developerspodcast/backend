using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevelopersPodcast.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DevelopersPodcast.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        private const string AllowedOrigins = "AllowedOrigins";

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(AllowedOrigins,
                    builder =>
                    {
                        builder.WithOrigins("*");
                        builder.WithHeaders("*");
                        builder.WithMethods("*");
                        builder.WithExposedHeaders("*");
                    });
            });

            services.AddControllers();
            services.AddPodcastDistributor(Configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors(AllowedOrigins);
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
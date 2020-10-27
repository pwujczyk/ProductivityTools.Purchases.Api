using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProductivityTools.Purchases.Api.Command;

namespace ProductivityTools.Purchases.Api
{
    public class Startup
    {
        readonly string policy = "policy";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(policy,
                    builder =>
                    {
                        builder.WithOrigins("http://localhost").AllowAnyHeader().AllowAnyMethod().Build();
                    });
            });

            services.AddControllers();
            services.RegisterePurchaseServices();   

            services.AddAuthentication("Bearer")
             .AddJwtBearer("Bearer", options =>
             {
                 // identity server issuing token
                 options.Authority = "https://localhost:5001";
                 options.RequireHttpsMetadata = false;
                 // the scope id of this api
                 options.Audience = "purchase.api";
             });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors(policy);
            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

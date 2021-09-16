using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Interfaces;
using DbContextLayer.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace StoreApplication
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "StoreApplication", Version = "v1" });
            });

            services.AddDbContext<P1_StoreApplicationDBContext>(options =>
            {
                // Connection String located in secrets.json
                if (!options.IsConfigured)
                {
                    options.UseSqlServer(Configuration.GetConnectionString("P1DB"));
                }
            });

            //registering classes with the DI system
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IModelMapper, ModelMapper>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "StoreApplication v1"));
            }

            // To enable default text-only handlers for common error status codes
            app.UseStatusCodePages();

            app.UseHttpsRedirection();

            // Use this to redirect to the index HTML for any random path
            app.UseRewriter(new RewriteOptions()
                .AddRedirect("^$", "index.html"));

            // Use the .js static files 
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

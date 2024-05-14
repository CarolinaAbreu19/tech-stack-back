using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStackBack.Business;
using TechStackBack.Interfaces;
using TechStackBack.IRepositories;
using TechStackBack.Repositories;
using TechStackProcesso.Data;

namespace TechStackBack
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TechStackBack", Version = "v1" });
            });

            //services.AddCors(o => o.AddPolicy("CORS_POLICY", builder =>
            //{
            //    builder
            //        .AllowAnyHeader()
            //        .AllowAnyMethod()
            //        .AllowAnyOrigin()
            //        .WithExposedHeaders(tusdotnet.Helpers.CorsHelper.GetExposedHeaders());
            //}));

            //services.AddCors(options =>
            //{
            //    options.AddPolicy("AllowSpecificOrigin",
            //        builder =>
            //        {
            //            builder.WithOrigins("http://localhost:4200")
            //                   .AllowAnyHeader()
            //                   .AllowAnyMethod()
            //                   .AllowCredentials();
            //        });
            //});

            services.AddCors(options =>
            {
                options.AddPolicy(
                    name: "CORS_POLICY",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:4200")
                            .AllowAnyMethod()
                            .AllowAnyHeader()
                            .AllowCredentials()
                            .WithExposedHeaders(tusdotnet.Helpers.CorsHelper.GetExposedHeaders());
                    });
            });

            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IAssuntoRepository, AssuntoRepository>();
            services.AddScoped<IAssuntoBusiness, AssuntoBusiness>();
            services.AddScoped<IColaboradorRepository, ColaboradorRepository>();
            services.AddScoped<IColaboradorBusiness, ColaboradorBusiness>();
            services.AddScoped<IRespostaRepository, RespostaRepository>();
            services.AddScoped<IRespostaBusiness, RespostaBusiness>();
            services.AddScoped<ITechStackRepository, TechStackRepository>();
            services.AddScoped<ITechStackBusiness, TechStackBusiness>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TechStackBack v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("CORS_POLICY");
            
            app.Use(async (httpContext, next) =>
            {
                var apiMode = httpContext.Request.Path.StartsWithSegments("/api");
                if (apiMode)
                {
                    httpContext.Request.Headers[HeaderNames.XRequestedWith] = "XMLHttpRequest";
                }
                await next();
            });
            
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers().RequireCors("CORS_POLICY");
            });

        }
    }
}

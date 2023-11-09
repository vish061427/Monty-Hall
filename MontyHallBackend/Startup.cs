using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MontyHallBackend.Services;
using System;

namespace MontyHallBackend{
    public class Startup{


        public Startup(IConfiguration configuration){
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services){
            services.AddControllers();
            //services.AddSingleton<MontyHallServices>();

            services.AddSwaggerGen(c =>{
                c.SwaggerDoc("v1",new OpenApiInfo { Title = "MontyHallBackend",Version = "v1" });
            });
            services.AddScoped<MontyHallServices>();
            services.AddLogging(builder => builder.AddConsole());

            services.AddCors(options =>{
                options.AddPolicy("AllowSpecificOrigin",
                builder =>{
                    builder.WithOrigins("http://localhost:4200")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env){
            if (env.IsDevelopment()){
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json","MontyHallBackend v1"));
            }
            else{
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePages();
            }

            app.UseCors("AllowSpecificOrigin");

            app.UseRouting();

            app.UseEndpoints(endpoints =>{
                endpoints.MapControllers();
            });
        }
    }
}
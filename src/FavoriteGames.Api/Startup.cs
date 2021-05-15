using FavoriteGames.Infra.CrossCutting.IoC;
using FavoriteGames.Infra.Rawg.Mapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FavoriteGames.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDomainNotifications();
            services.AddServices();
            
            services.AddRawg(Configuration);

            services.AddCors(Configuration);
            services.AddSecurity(Configuration);
            services.AddSwagger(Configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            
            app.UseRouting();

            app.UseSecurity(Configuration);
                        
            app.UseCors(Configuration);

            app.UseSwagger(Configuration, env.IsDevelopment());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("FavoriteGames API Started.");
                });

                endpoints.MapControllers();
            });
        }
    }
}
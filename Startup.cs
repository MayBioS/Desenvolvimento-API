using Api.Contexts;
using System;

namespace Api{
    public class Startup{
        public void ConfigureServices(IServiceCollection services){
            services.AddScoped<ChapterContext, ChapterContext>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env){
            if(env.IsDevelopment()){
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints => {
                endpoints.MapGet("/", async context =>{
                    await context.Response.WriteAsync("Olá Mundo");
                });
            });
        }
    }
}
//====================================================
// Copyright (c) Coalition Of Good-Hearted Engineers
// EVERY LITTLE HELPS
//====================================================

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace xChangerLite.Core
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();

                app.UseSwaggerUI(config =>
                    config.SwaggerEndpoint(
                        url: "/swagger/v1/swagger.json",
                        name: "xChanger.Core.POC v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
                endpoints.MapControllers());
        }
    }
}

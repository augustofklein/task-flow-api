﻿using TaskFlowManager.WebApi.DependenyInjection;

namespace TaskFlowManager.WebApi
{
    public class Startup(IConfiguration configuration)
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDatabaseInjection(configuration);
            services.AddControllers();

            //services.ConfigureServicesExtensions(configuration);

            /*
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            });
            */

            services.AddHealthChecks();
            services.AddEndpointsApiExplorer();

            services.AddMediatorInjection();
            //services.AddServices();
            //services.AddQueries();
            //services.AddRepositories();
            //services.AddHandles();
            //services.AddMemoryCache();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseMiddleware<Middleware>();
            app.UseRouting();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHealthChecks("/health");
            });
        }
    }
}

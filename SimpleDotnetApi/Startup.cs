using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SimpleDotnetApi.Domain.Repositories;
using SimpleDotnetApi.Persistence.Repositories;
using SimpleDotnetApi.Domain.Services;
using SimpleDotnetApi.Services;
using RestSharp;
using Microsoft.Extensions.Configuration;

namespace SimpleDotnetApi
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        private readonly string DefaultCorsPolicy = "DefaultCorsPolicy";
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                .AddNewtonsoftJson();

            services.AddCors(options =>
            {
                options.AddPolicy(DefaultCorsPolicy, policyOptions =>
                {
                    policyOptions.WithOrigins(_configuration["CorsEnabledOrigins"].Split(';'));
                });
            });

            services.AddScoped<IRestClient, RestClient>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IUsersService, UsersService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors(DefaultCorsPolicy);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

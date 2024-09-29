using Fintrack.Infraestructure;
using Fintrack.Infraestructure.Extensions;
using FinTrack.Api.Configurations;
using FinTrack.Application;
using FluentValidation.AspNetCore;
using Microsoft.OpenApi.Models;

namespace FinTrack;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    // This method gets called by the runtime. Use this method to add services to the container
    [Obsolete]
    public void ConfigureServices(IServiceCollection services)
    {
        var builder = WebApplication.CreateBuilder();

        var appConfigs = builder.AddAppConfigs();

        services.AddInfra(builder.Configuration);
        services.AddApplication();

        services.AddControllers()
            .AddFluentValidation(x => x.AutomaticValidationEnabled = false)
            .AddCustomJsonOptions()
            .ConfigureApiBehaviorOptions(options =>
                options.SuppressInferBindingSourcesForParameters = true
            );
        
        services.AddAppConnections(builder.Configuration);
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(setup => {
            setup.SwaggerDoc("v1", new OpenApiInfo()
            {
                Title = "Fintrack Bff",
                Version = "v1"
            });
            setup.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
            {
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header
            });
            var scheme = new OpenApiSecurityScheme()
            {
                Reference = new OpenApiReference()
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            };
            setup.AddSecurityRequirement(new OpenApiSecurityRequirement()
            {
                { scheme, Array.Empty<string>() }
            });
        });

        services
            .AddApiVersioning()
            .AddAutoMapper();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();
        
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
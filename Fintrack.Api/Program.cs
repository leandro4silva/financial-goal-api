using Fintrack.Infraestructure;
using Fintrack.Infraestructure.Extensions;
using FinTrack.Api.Configurations;
using FinTrack.Application;
using FluentValidation.AspNetCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Configurações da aplicação
var appConfigs = builder.AddAppConfigs();

// Adicionando serviços ao contêiner
builder.Services.AddInfra(builder.Configuration);
builder.Services.AddApplication();

builder.Services.AddControllers()
    .AddFluentValidation(x => x.AutomaticValidationEnabled = false)
    .AddCustomJsonOptions()
    .ConfigureApiBehaviorOptions(options =>
        options.SuppressInferBindingSourcesForParameters = true
    );

builder.Services.AddAppConnections(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(setup =>
{
    setup.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Fintrack Bff",
        Version = "v1"
    });

    setup.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header
    });

    var scheme = new OpenApiSecurityScheme
    {
        Reference = new OpenApiReference
        {
            Type = ReferenceType.SecurityScheme,
            Id = "Bearer"
        }
    };

    setup.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { scheme, Array.Empty<string>() }
    });
});

builder.Services
    .AddApiVersioning()
    .AddAutoMapper();

var app = builder.Build();

// Configuração do pipeline de requisição HTTP
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
using AutoMapper;
using FinTrack.Application.Mappers;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Fintrack.Infraestructure.Extensions;

[ExcludeFromCodeCoverage]
public static class AutoMapperExtensions
{
    public static IServiceCollection AddAutoMapper(this IServiceCollection services)
    {
        var configuration = new MapperConfiguration(ConfigureMapper);
        services.AddSingleton(configuration.CreateMapper());

        return services;
    }

    public static void ConfigureMapper(IMapperConfigurationExpression config)
    {
        config.AddProfile<GoalMapper>();
    }
}

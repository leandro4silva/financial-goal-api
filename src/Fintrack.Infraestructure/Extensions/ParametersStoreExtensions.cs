using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace Fintrack.Infraestructure.Extensions;

public static class ParametersStoreExtensions
{
    public static WebApplicationBuilder AddAwsParameters(this WebApplicationBuilder builder)
    {
        var awsPaths = builder.Configuration
            .GetSection("AwsParametersPaths")
            .Get<ICollection<string>>() ?? Enumerable.Empty<string>();

        var awsPathWithReload = builder.Configuration
            .GetSection("AwsParametersPathWithRealod")
            .Get<ICollection<string>>() ?? Enumerable.Empty<string>();

        return builder;
    }
}

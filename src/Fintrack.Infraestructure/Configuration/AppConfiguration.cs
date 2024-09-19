using System.Diagnostics.CodeAnalysis;

namespace Fintrack.Infraestructure.Configuration;

[ExcludeFromCodeCoverage]
public class AppConfiguration
{
    private const string EnvironmentDev = "Development";
    private const string EnvironmentHom = "Staging";

    public string? Environment { get; set; }

    public bool IsDevelopment =>
        EnvironmentDev.Equals(Environment,
            StringComparison.OrdinalIgnoreCase);

    public bool IsStaging => 
        EnvironmentHom.Equals(Environment, 
            StringComparison.OrdinalIgnoreCase);
}

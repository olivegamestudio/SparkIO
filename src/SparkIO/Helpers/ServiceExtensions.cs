using Microsoft.Extensions.DependencyInjection;

namespace SparkIO;

public static class ServiceExtensions
{
    public static IServiceCollection AddSparkIO(this IServiceCollection services)
    {
        services.AddSingleton<IFileSystem, FileSystem>();
        return services;
    }
}

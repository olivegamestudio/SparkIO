using Microsoft.Extensions.DependencyInjection;

namespace Utility;

public static class ServiceExtensions
{
    public static IServiceCollection AddFileSystem(this IServiceCollection services)
    {
        services.AddSingleton<IFileSystem, Utility.FileSystem>();
        return services;
    }
}

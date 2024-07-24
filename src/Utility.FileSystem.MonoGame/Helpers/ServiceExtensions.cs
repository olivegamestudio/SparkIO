using Microsoft.Extensions.DependencyInjection;

namespace Utility;

public static class ServiceExtensions
{
    public static IServiceCollection AddFileSystemMonoGame(this IServiceCollection services)
    {
        services.AddSingleton<IFileSystem, FileSystemMonoGame>();
        return services;
    }
}

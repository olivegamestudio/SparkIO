using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Xna.Framework;

namespace Utility;

/// <summary>
/// Defines a set of methods for working with the file system by using MonoGame calls.
/// </summary>
public class FileSystemMonoGame : IFileSystem
{
    readonly ILogger<FileSystemMonoGame>? _logger;

    public FileSystemMonoGame()
    {
    }

    public FileSystemMonoGame(ILogger<FileSystemMonoGame> logger)
    {
        _logger = logger;
    }

    /// <inheritdoc />
    public Task<Stream> OpenStreamAsync(string filename)
    {
        _logger?.LogInformation($"Loading texture: '{filename}'...");
        return Task.FromResult(TitleContainer.OpenStream(filename));
    }
}

using Microsoft.Extensions.Logging;
using System.IO;
using System.Threading.Tasks;
using Utility;

namespace SparkIO;

/// <summary>
/// Defines a set of methods for working with the file system by using standard calls.
/// </summary>
public class FileSystem : IFileSystem
{
    readonly ILogger<FileSystem> _logger;

    public FileSystem(ILogger<FileSystem> logger = null)
    {
        _logger = logger;
    }

    /// <inheritdoc />
    public Task<Stream> OpenStreamAsync(string filename)
    {
        filename = Guard.ThrowIfStringNullOrEmpty(filename);
        _logger?.LogInformation($"Opening stream: '{filename}'...");
        return Task.FromResult((Stream)File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.Read));
    }
}

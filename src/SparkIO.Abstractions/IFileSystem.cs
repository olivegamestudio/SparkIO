using System.IO;
using System.Threading.Tasks;

namespace SparkIO;

/// <summary>
/// Defines a set of methods for working with file systems.
/// </summary>
public interface IFileSystem
{
    /// <summary>
    /// Asynchronously opens a stream for the specified file.
    /// </summary>
    /// <param name="filename">The name of the file to open a stream for.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the opened stream.</returns>
    Task<Stream> OpenStreamAsync(string filename);
}

using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace Utility;

/// <summary>
/// Defines a set of methods for working with the file system by using standard calls.
/// </summary>
public class FileSystem : IFileSystem
{
    /// <inheritdoc />
    public Task<Stream> OpenStreamAsync(string filename)
    {
        Debug.Assert(!string.IsNullOrEmpty(filename));
        return Task.FromResult((Stream)File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.Read));
    }
}

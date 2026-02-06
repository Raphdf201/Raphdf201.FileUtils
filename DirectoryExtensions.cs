using System.IO;

namespace Raphdf201.FileUtils;

public static class DirectoryExtensions
{
    extension(Directory)
    {
        public static string? GetName(string path) => Path.GetDirectoryName(path);
    }
}

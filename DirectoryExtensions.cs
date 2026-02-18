using System;
using System.IO;

namespace Raphdf201.FileUtils;

public static class DirectoryExtensions
{
    extension(Directory)
    {
        [Obsolete]
        public static string? GetName(string path) => Path.GetDirectoryName(path);
        public static string? GetDirectoryName(string path) => Path.GetDirectoryName(path);
    }
}

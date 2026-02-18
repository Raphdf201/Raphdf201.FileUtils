using System;
using System.IO;

namespace Raphdf201.FileUtils;

public static class FileExtensions
{
    extension(File)
    {
        [Obsolete]
        public static string GetName(string path) => Path.GetFileName(path);
        public static string? GetFileName(string path) => Path.GetFileName(path);
    }
}
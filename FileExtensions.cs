using System;
using System.IO;

namespace Raphdf201.FileUtils;

public static class FileExtensions
{
    extension(File)
    {
        public static string GetName(string path) => Path.GetFileName(path);
    }

    extension(string path)
    {
        public string? GetFileName() => Path.GetFileName(path);
    }
}

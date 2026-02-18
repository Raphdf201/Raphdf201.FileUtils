using System;
using System.IO;

namespace Raphdf201.FileUtils;

public static class FileExtensions
{
    extension(File)
    {
        public static string GetName(string path) => Path.GetFileName(path);
    }

    extension(string)
    {
        public static string? GetFileName(string path) => Path.GetDirectoryName(path);
    }
}
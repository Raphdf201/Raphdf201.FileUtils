using System.IO;

namespace Raphdf201.FileUtils;

public static class PathExtensions
{
    extension(string path)
    {
        public string Combine(string other) => Path.Combine(path, other);
        public string Combine(params string[] others) => Path.Combine([path, ..others]);
    }
}

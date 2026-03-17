using System.IO;

namespace Raphdf201.FileUtils;

public static class PathExtensions
{
    extension(string path)
    {
        /// <summary>
        /// Combines 2 paths using <see cref="Path.Combine(string, string)"/>
        /// </summary>
        /// <returns>The combination of both paths</returns>
        public string Combine(string other) => Path.Combine(path, other);
        /// <summary>
        /// Combines multiple paths using <see cref="Path.Combine(string[])"/>
        /// </summary>
        /// <returns>The combination of all paths</returns>
        public string Combine(params string[] others) => Path.Combine([path, ..others]);
    }
}

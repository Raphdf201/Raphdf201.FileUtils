using System.IO;

namespace Raphdf201.FileUtils;

public static class DirectoryExtensions
{
    extension(Directory)
    {
        /// <summary>
        /// Gets the name (no path) of the specified directory
        /// </summary>
        /// <param name="path">The path of the directory</param>
        /// <returns>The name of the directory</returns>
        public static string? GetName(string path) => Path.GetDirectoryName(path);
    }

    extension(string path)
    {
        /// <summary>
        /// Get the name of the directory (no path)
        /// </summary>
        /// <returns>The name of the directory (no path)</returns>
        public string? GetDirectoryName() => Directory.GetName(path);

        /// <summary>
        /// Creates the specified directory if it does not exist and returns it
        /// </summary>
        /// <returns>The path of the created directory</returns>
        public string CreateDirectory()
        {
            Directory.CreateDirectory(path);
            return path;
        }
    }
}

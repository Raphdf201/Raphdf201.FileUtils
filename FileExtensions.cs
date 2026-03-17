using System.IO;

namespace Raphdf201.FileUtils;

public static class FileExtensions
{
    extension(File)
    {
        /// <summary>
        /// Gets the name with extension of the file specified (no path)
        /// </summary>
        /// <param name="path">The path of the file to get the name of</param>
        /// <returns>The name with extension</returns>
        public static string GetName(string path) => Path.GetFileName(path);
    }

    extension(string path)
    {
        /// <summary>
        /// Gets the name with extension of the file (no path)
        /// </summary>
        /// <returns>The name with extension</returns>
        public string GetFileName() => File.GetName(path);
    }
}

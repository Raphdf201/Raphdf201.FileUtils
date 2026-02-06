using Std = System.IO;

namespace Raphdf201.FileUtils;

public class Path(string path)
{
    /// <returns>The path as a string</returns>
    public override string ToString() => path;

    public static Path Of(params string[] paths) => new(Std.Path.Combine(paths));
}

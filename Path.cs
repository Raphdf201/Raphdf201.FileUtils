using Std = System.IO;

namespace Raphdf201.FileUtils;

public class Path(string path)
{
    /// <returns>The path as a string</returns>
    public override string ToString() => path;

    public static Path Of(params string[] paths) => new(Std.Path.Combine(paths));

    public Path Append(string otherPath) => Of(path, otherPath);

    public Directory CreateDirectory()
    {
        var dir = new Directory(this);
        dir.Create();
        return dir;
    }

    public File CreateFile()
    {
        var file = new File(this);
        file.Create();
        return file;
    }
}

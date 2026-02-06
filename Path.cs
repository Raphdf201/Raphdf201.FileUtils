using System.Linq;
using Std = System.IO;

namespace Raphdf201.FileUtils;

public class Path(string path)
{
    /// <returns>The path as a string</returns>
    public override string ToString()
    {
        return path;
    }

    public static Path Of(params string[] paths)
    {
        return new Path(Std.Path.Combine(paths));
    }
    
    public static Path Of(params Path[] paths)
    {
        return new Path(Std.Path.Combine(paths.Select(p => p.ToString()).ToArray()));
    }

    public Path Append(string otherPath)
    {
        return Of(path, otherPath);
    }

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

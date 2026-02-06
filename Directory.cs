using System.Collections.Generic;
using Std = System.IO;

namespace Raphdf201.FileUtils;

public class Directory
{
    private readonly Path _path;

    public Directory(string path)
    {
        _path = new Path(path);
    }

    public Directory(Path path)
    {
        _path = path;
    }

    public void Create() => Std.Directory.CreateDirectory(_path.ToString());

    public bool Exists() => Std.Directory.Exists(_path.ToString());

    public IEnumerable<string> EnumerateFiles() => Std.Directory.EnumerateFiles(_path.ToString());
    public IEnumerable<string> EnumerateDirectories() => Std.Directory.EnumerateDirectories(_path.ToString());

    public void CreateIfNoExists()
    {
        if (!Exists()) Create();
    }
}

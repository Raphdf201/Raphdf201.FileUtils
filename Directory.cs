using System.Collections.Generic;
using System.Linq;
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

    public void Create()
    {
        Std.Directory.CreateDirectory(_path.ToString());
    }

    public bool Exists()
    {
        return Std.Directory.Exists(_path.ToString());
    }

    public IEnumerable<File> EnumerateFiles()
    {
        return Std.Directory.EnumerateFiles(_path.ToString()).Select(f => new File(f));
    }

    public IEnumerable<Directory> EnumerateDirectories()
    {
        return Std.Directory.EnumerateDirectories(_path.ToString()).Select(d => new Directory(d));
    }

    public void CreateIfNoExists()
    {
        if (!Exists()) Create();
    }
}

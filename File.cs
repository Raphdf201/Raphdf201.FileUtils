using System;
using Std = System.IO;

namespace Raphdf201.FileUtils;

public class File
{
    private readonly Path _path;

    public File(string path)
    {
        _path = new Path(path);
    }

    public File(Path path)
    {
        _path = path;
    }

    public string GetName()
    {
        return Std.Path.GetFileName(_path.ToString());
    }

    public Path GetPath()
    {
        return _path;
    }

    public void Copy(File dest)
    {
        Std.File.Copy(_path.ToString(), dest.GetPath().ToString());
    }

    public void Create()
    {
        Std.File.WriteAllText(_path.ToString(), "");
    }

    public void Delete()
    {
        Std.File.Delete(_path.ToString());
    }

    public DateTime GetLastWriteTime()
    {
        return Std.File.GetLastWriteTime(_path.ToString());
    }
}

using System;
using Std = System.IO;

namespace Raphdf201.FileUtils;

public class File(string path)
{
    public string GetName() => Std.Path.GetFileName(path);

    public Path GetPath() => new(path);

    public void Copy(File dest) => Std.File.Copy(path, dest.GetPath().ToString());

    public void Delete() => Std.File.Delete(path);

    public DateTime GetLastWriteTime() => Std.File.GetLastWriteTime(path);
}

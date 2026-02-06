using System.Collections.Generic;
using Std = System.IO;

namespace Raphdf201.FileUtils;

public class Directory(string path)
{
    public void Create() => Std.Directory.CreateDirectory(path);

    public bool Exists() => Std.Directory.Exists(path);

    public IEnumerable<string> EnumerateFiles() => Std.Directory.EnumerateFiles(path);
    public IEnumerable<string> EnumerateDirectories() => Std.Directory.EnumerateDirectories(path);

    public void CreateIfNoExists()
    {
        if (!Exists()) Create();
    }
}

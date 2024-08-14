namespace Task3ConsoleApp;
public class FileSystemVisitor
{
    private string RootDirectory { get; init; }
    public FileSystemVisitor(string directory)
    {
        RootDirectory = directory;
    }

    public IEnumerable<string> getDirectoryFilesAndFolders()
    {
        List<string> filesAndDirectories = new List<string>();
        IEnumerable<string> directories = Directory.EnumerateDirectories(RootDirectory);
        foreach (string directory in directories)
        {
            filesAndDirectories.Add(directory);
            
        }
        IEnumerable<string> files = Directory.EnumerateFiles(RootDirectory);

        return directories.Concat(files);
    }

}

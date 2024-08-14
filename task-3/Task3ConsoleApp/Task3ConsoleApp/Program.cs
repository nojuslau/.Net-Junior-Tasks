using Microsoft.AspNetCore.Hosting;
using Task3ConsoleApp;

namespace MyNamespace;
class Task3ConsoleApp
{
    static void Main(string[] args)
    {
        string path = Directory.GetCurrentDirectory();
        FileSystemVisitor fileSystemVisitor = new FileSystemVisitor(path);
        IEnumerable<string> files = fileSystemVisitor.getDirectoryFilesAndFolders();
        Console.WriteLine(files);
    }
}
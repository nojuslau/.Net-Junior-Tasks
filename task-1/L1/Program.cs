using HelloWorldStandardLibrary;

namespace L1;

class Program
{
    public static void Main(string[] args)
    {
        string username = Console.ReadLine() ?? string.Empty;
        Console.WriteLine(HelloWorldLibrary.IsUsername(username));
    }
}

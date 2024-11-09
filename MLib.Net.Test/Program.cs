using MLib.Helpers;

namespace MLib.Net.Test;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

		FileHelper.EnsureFileExists("test.txt", "salkdfjaslkdjflkasdjf");

        FileHelper.EnsureDirectoryExists("test/testy");
        
    }
}
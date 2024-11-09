using System.Text;

namespace MLib.Helpers;

public static class FileHelper
{
    public static void EnsureFileExists(string filePath, string? initialContent = null)
    {
        string path = Path.GetFullPath(filePath);
        
        // can throw ArgumentExeption if the path is not fully qualified of the path contains invalid characters
        
        string? directory = Path.GetDirectoryName(path);
        
        // can throw PathTooLongException if the path is too long
        
        if (directory != null) 
            Directory.CreateDirectory(directory);

        if(!File.Exists(path))
            File.WriteAllText(path, initialContent);

    }

    public static void EnsureDirectoryExists(string path)
    {
        path = Path.GetFullPath(path);
        
        Directory.CreateDirectory(path);
    }
    
}
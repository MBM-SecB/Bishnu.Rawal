using System;
using System.IO;

public class FileIO
{
    public void LearnFileReading()
    {
        string filePath = @"D:\Computer Science\.NET Centric Computing\Lab\Bishnu.Rawal\README.md";
        string fileWithInProject = "Generics.cs";

        bool isFileThere = File.Exists(fileWithInProject);

        if (isFileThere)
        {
            var fileContent = File.ReadAllText(fileWithInProject);
            Console.WriteLine(fileContent);
        }
    }

    public void LearnFileWriting()
    {
        string filePath = "Abc.txt";
        File.WriteAllText(filePath, "This is random file content.");
    }

    public void LearnFileInfo()
    {
        string filePath = "Abc.txt";
        FileInfo fileInfo = new FileInfo(filePath);

        var size = fileInfo.Length;
        var createDate = fileInfo.CreationTime;

        Console.WriteLine(filePath);
        Console.WriteLine($"Size: {size} bytes");
        Console.WriteLine($"Created: {createDate}");
    }

    public void LearnDirectory()
    {
        string folderPath = "MBM";
        Directory.CreateDirectory(folderPath);

        Console.WriteLine("Do you want to delete MBM folder?");
        string confirm = Console.ReadLine();
        if (confirm == "Y")
        {
            Directory.Delete(folderPath);
        }
    }

    // HW: Create a folder "Nepal", with in that create 10 sub folders. Every
    // subfolders should contain a file Test.txt with subfolder name as a content. 
}
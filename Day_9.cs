using System;
using System.IO;

class Program
{
    static void Main()
    {
        string folderPath = @"D:\Amadis_training\C#\Directories\NewFolder";
        if (Directory.Exists(folderPath))
        {
            Console.WriteLine("Directory already exists: " + folderPath);
        }
        else
        {
            Directory.CreateDirectory(folderPath);
            Console.WriteLine("New directory created: " + folderPath);
        }

        //Directory.Delete(folderPath);
    }
}

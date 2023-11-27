using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string FilePath = "C:\\Users\\kapoo_oeyqv\\OneDrive\\Desktop\\Tanish_kapoor.txt";

            if (File.Exists(FilePath))
            {
                Console.WriteLine("Please enter a new name for the file (including extension):");
                string newFilePath2 = Console.ReadLine();

                if (!string.IsNullOrEmpty(newFilePath2))
                {
                    string newFilePath = Path.Combine(Path.GetDirectoryName(FilePath), newFilePath2);
                    File.Move(FilePath, newFilePath);
                    if (File.Exists(newFilePath))
                    {
                        Console.WriteLine($"The file was renamed to {newFilePath}");
                    }
                    else
                    {
                        Console.WriteLine("File renaming failed.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid file name. Please provide a non-empty name.");
                }
            }
            else
            {
                Console.WriteLine("Original file does not exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.ReadKey();
    }
}

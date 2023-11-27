using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\kapoo_oeyqv\\OneDrive\\Desktop\\Tanish_kapoor.txt";
        string existingContent = "";  // Declare the variable outside the if block

        try
        {
            if (File.Exists(filePath))
            {
                existingContent = File.ReadAllText(filePath);

                Console.WriteLine("Current content of the file:\n" + existingContent);
            }
            else
            {
                Console.WriteLine("File does not exist. Creating a new file.");
            }

            Console.WriteLine("\nPlease enter your specialization:");
            string specialization = Console.ReadLine();

            string updatedContent = $"{existingContent}\nSpecialization: {specialization}";

            File.WriteAllText(filePath, updatedContent);

            Console.WriteLine("\nSpecialization appended successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

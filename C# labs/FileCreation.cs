using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\kapoo_oeyqv\\OneDrive\\Desktop\\Tanish_kapoor.txt"; // Specify the full path

        Console.WriteLine("Please enter your registration no:");
        string newContent = Console.ReadLine();

        while (newContent.ToLower() != "exit")
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(newContent);
                }

                Console.WriteLine("Content appended successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            newContent = Console.ReadLine();
        }
    }
}

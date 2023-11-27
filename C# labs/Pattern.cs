using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter the number of rows for the pyramid:");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= i; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for the number of rows.");
        }
    }
}

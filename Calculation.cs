using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int addition = num1 + num2;
            int subtraction = num1 - num2;
            int multiplication = num1 * num2;
            int division = num1 / num2;

            Console.WriteLine($"Addition: {addition}");
            Console.WriteLine($"Subtraction: {subtraction}");
            Console.WriteLine($"Multiplication: {multiplication}");
            Console.WriteLine($"Division: {division}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter integers only.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

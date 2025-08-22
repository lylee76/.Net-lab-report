using System;

// Define custom exception
/*class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a positive number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Throw custom exception if number is negative
            if (num < 0)
                throw new NegativeNumberException("Negative number is not allowed!");

            Console.WriteLine("You entered: " + num);
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine("Custom Exception: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid integer.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Program ended.");
        }
    }
}
*/

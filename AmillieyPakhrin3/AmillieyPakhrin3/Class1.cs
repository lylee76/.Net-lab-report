using System;

/*namespace MulticastDelegateExample
{
    // Declare delegate
    delegate void ShowMessage();

    class Program
    {
        // First method
        static void DisplayHello()
        {
            Console.WriteLine("Hello");
        }

        // Second method
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to C# Delegates!");
        }

        static void Main()
        {
            // Create delegate instance
            ShowMessage messageDelegate;

            // Add first method
            messageDelegate = DisplayHello;

            // Add second method (combine)
            messageDelegate += DisplayWelcome;

            // Call the multicast delegate
            Console.WriteLine("Calling multicast delegate:");
            messageDelegate();

            // Remove a method from delegate
            messageDelegate -= DisplayHello;

            Console.WriteLine("\nAfter removing DisplayHello:");
            messageDelegate();
        }
    }
}
*/

using System;

/*namespace AmillieyPakhrin1
{
    class Q12
    {
        static void Main()
        {
            Console.Write("Enter number of .NET Technology marks to input: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] marks = new int[n];
            int sum = 0;

            // Input marks
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                sum += marks[i];
            }

            // Initialize min and max with first value
            int min = marks[0];
            int max = marks[0];

            // Loop through array to find min and max
            for (int i = 1; i < n; i++)
            {
                if (marks[i] < min)
                    min = marks[i];
                if (marks[i] > max)
                    max = marks[i];
            }

            double average = (double)sum / n;

            // Display results
            Console.WriteLine($"\nMinimum Mark: {min}");
            Console.WriteLine($"Maximum Mark: {max}");
            Console.WriteLine($"Average Mark: {average:F2}");

        }
    }
}
*/
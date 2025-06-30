using System;

namespace AmillieyPakhrin1
{
  /*  class Q11
    {
        static void Main()
        {
            Console.Write("Enter number of rows for Matrix A: ");
            int rowsA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of columns for Matrix A (and rows for Matrix B): ");
            int colsA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of columns for Matrix B: ");
            int colsB = Convert.ToInt32(Console.ReadLine());

            // Declare jagged arrays
            int[][] A = new int[rowsA][];
            int[][] B = new int[colsA][];
            int[][] result = new int[rowsA][];

            // Initialize each row of jagged arrays
            for (int i = 0; i < rowsA; i++)
                A[i] = new int[colsA];

            for (int i = 0; i < colsA; i++)
                B[i] = new int[colsB];

            for (int i = 0; i < rowsA; i++)
                result[i] = new int[colsB];

            // Input Matrix A
            Console.WriteLine("\nEnter elements of Matrix A:");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    Console.Write($"A[{i},{j}]: ");
                    A[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Input Matrix B
            Console.WriteLine("\nEnter elements of Matrix B:");
            for (int i = 0; i < colsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    Console.Write($"B[{i},{j}]: ");
                    B[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Print Matrix A
            Console.WriteLine("\nMatrix A:");
            PrintMatrix(A);

            // Print Matrix B
            Console.WriteLine("\nMatrix B:");
            PrintMatrix(B);

            // Multiply A × B
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    result[i][j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        result[i][j] += A[i][k] * B[k][j];
                    }
                }
            }

            // Print Result
            Console.WriteLine("\nResult of Matrix Multiplication (A x B):");
            PrintMatrix(result);
        }

        static void PrintMatrix(int[][] matrix)
        {
            foreach (int[] row in matrix)
            {
                foreach (int val in row)
                {
                    Console.Write(val + "\t");
                }
                Console.WriteLine();
            }
        }
    }*/
}

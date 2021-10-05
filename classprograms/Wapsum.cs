using System;

public class SumMatrix
{
    public static void Main()
    {
        int rows, cols;

        int[,] a = {
                          {1, 0, 1},
                          {4, 5, 6},
                          {1, 2, 3}
                     };

        int[,] b = {
                          {1, 1, 1},
                          {2, 3, 1},
                          {1, 5, 1}
                    };

        rows = a.GetLength(0);
        cols = a.GetLength(1);

        int[,] sum = new int[rows, cols];

         for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sum[i, j] = a[i, j] + b[i, j];
            }
        }

        Console.WriteLine("Addition of two matrices: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(sum[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
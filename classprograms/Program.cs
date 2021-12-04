using System;
namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int i, j;
            for (i = 1; i <= 7; i++)
            {
                var result = i <= 4?k++:k--;

                for (j = 1; j <= 4; j++)
                {
                    if (j<=k)
                    {

                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
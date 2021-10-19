using System;

class Test
{
    static int factorial(int n)
    {
        int res = 1, i;

        for (i = 2; i <= n; i++)
            res *= i;
        return res;
    }

    public static void Main()
    {
        int num = 6;
        Console.WriteLine(
            "Factorial of " + num
            + " is " + factorial(6));
    }
}
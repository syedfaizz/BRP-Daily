using System;

class GFG
{

    static bool isEven(int n)
    {

        return ((n / 2) * 2 == n);
    }

    public static void Main(String[] args)
    {

        int n = 101;

        if (isEven(n) != false)

            Console.Write("Even");

        else

            Console.Write("Odd");
    }
}
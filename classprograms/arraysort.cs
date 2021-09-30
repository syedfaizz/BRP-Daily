using System;

class Program
{

    public static void Main()

    {

        int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };


        Array.Sort(arr);


        // reverse array 

        Array.Reverse(arr);


        foreach (int value in arr)

        {

            Console.Write(value + " ");

        }

    }
}
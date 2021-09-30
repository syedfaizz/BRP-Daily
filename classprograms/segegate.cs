using System;
class segregate
{
    static void segregate0and1(int[] arr, int n)

    {
        int count = 0;

        for (int i = 0; i < n; i++)
        {

            if (arr[i] == 0)

                count++;

        }

        for (int i = 0; i < count; i++)

            arr[i] = 0;

        for (int i = count; i < n; i++)

            arr[i] = 1;

    }

    static void print(int[] arr, int n)

    {

        Console.WriteLine("Array after segregation is ");

        for (int i = 0; i < n; i++)

            Console.Write(arr[i] + " ");

    }
    public static void Main()

    {

        int[] arr = new int[] { 1, 1, 0, 1, 0, 0, 1 };

        int n = arr.Length;

        segregate0and1(arr, n);

        print(arr, n);

    }
}
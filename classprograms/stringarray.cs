using System;

class Program
{
    static void Main()
    {
        string[] pets = new string[] { "dog", "bird", "cat" };

        Array.Sort(pets);

        foreach (string pet in pets)
        {
            Console.WriteLine(pet);
        }
    }
}

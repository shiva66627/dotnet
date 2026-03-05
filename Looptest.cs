
using System;

class LoopTest
{
    static void Main()
    {
        string name = "Shivakumar";

        // Using FOR loop
        Console.WriteLine("Using for loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(name);
        }

        // Using WHILE loop
        Console.WriteLine("\nUsing while loop:");
        int j = 1;
        while (j <= 5)
        {
            Console.WriteLine(name);
            j++;
        }
    }
}

// ArrayTest.cs
using System;

class ArrayTest
{
    static void Main()
    {
        string[] students = { "Ravi", "Sita", "Arjun", "Meena" };

        Console.WriteLine("Using for loop:");
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine(students[i]);
        }

        Console.WriteLine("\nUsing foreach loop:");
        foreach (string name in students)
        {
            Console.WriteLine(name);
        }
    }
}

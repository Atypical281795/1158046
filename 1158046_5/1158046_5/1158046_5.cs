using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of Elements of List : ");
        int n = int.Parse(Console.ReadLine());
        List<string> petNames = new List<string>();

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter Element {i} : ");
            petNames.Add(Console.ReadLine());
        }

        Console.WriteLine("\nYou entered the Elements as :");
        foreach (string name in petNames)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("\nList with elements in increasing alphabetic lengths :");
        var ascendingOrder = petNames.OrderBy(name => name.Length).ToList();
        foreach (string name in ascendingOrder)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("\nList with elements in decreasing alphabetic lengths :");
        var descendingOrder = petNames.OrderByDescending(name => name.Length).ToList();
        foreach (string name in descendingOrder)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("\nNon repeating elements are :");
        var distinctNames = petNames.Distinct().ToList();
        foreach (string name in distinctNames)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine($"\nList has {distinctNames.Count} non-repeating elements");
        Console.Read();
    }
}
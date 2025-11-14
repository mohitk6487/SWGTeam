using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class CollectionOptions
{
    public static void Collections()
    {
        List<string> names = new List<string>() { "Sukhi", "Neha", "Vikas", "Mohit"};           // Ordered collection, allows duplicates
        HashSet<int> numbers = new HashSet<int>() { 1, 2, 2, 3, 4, 5, 5 };               // Duplicate '5' will be ignored, HashSet does not follow indexing/ordering
        Dictionary<int, string> empDetails = new Dictionary<int, string>()              // Key-Value pairs
    {
        {101, "Sukhi" },
        {102, "DigVijay" },
        {103, "Karun" }
    };
        Console.WriteLine("List of Names:");
        foreach (string name in names)
        {
            Console.WriteLine("\t" + name);
        }
        Console.WriteLine("\nHashSet of Numbers (duplicates removed):");
        foreach (int number in numbers)
        {
            Console.WriteLine("\t" + number);
        }
        Console.WriteLine("\nDictionary of Employee Details:");
        foreach (KeyValuePair<int, string> emp in empDetails)
        {
            Console.WriteLine($"\tID: {emp.Key}, Name: {emp.Value}");
        }
        names.AddRange(empDetails.Values);                                            // Combining names from List and Dictionary values
        Console.WriteLine("\nCombined List of Names from List and Dictionary:");
        foreach (string name in names)
        {
            Console.WriteLine("\t" + name);
        }

    }
}


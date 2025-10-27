using System;
class ListExample
{
    public static void Mohit()
    {
        List<string> Fruits = new List<string>() { "Apple", "Banana", "Cherry", "Dragon Fruit" };
        List<double> Price = new List<double>() { 100, 40, 120, 90 };
        int i = 0;
        Console.WriteLine("{0, 5} {1, -20} {2, -35}", "S.NO.", "| Fruit", "| Price/KG");
        foreach (string fruit in Fruits)
        {
            
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("{0, 5} {1, -20} {2, -35}", i+1, "| "+fruit , "| "+Price[i]);
            i++;
        }
        Console.WriteLine(new string('-', 50));
    }
}


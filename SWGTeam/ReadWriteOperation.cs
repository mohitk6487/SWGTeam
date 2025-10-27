using System;

class ReadWriteMohit
{
    public static void Run()
    {
        Console.WriteLine("Please let me know your Name.");

        string name = Console.ReadLine();

        Console.WriteLine("Hello {0} in how many days you are thinking of learning C# with Selinium", name);

        string time = Console.ReadLine();

        Console.WriteLine("Sure {0}, Lets Start learning C# with seleinium in {1} days. Ready to Rock", name, time);

        //Console.WriteLine("Hello " + name+ ", in how many days you are thinking of learning C# with Selinium");
        //string time = Console.ReadLine();
        //Console.WriteLine("Sure " + name + ", Lets Start learning C# with seleinium in " + time + " days. Ready to Rock");
    }
}
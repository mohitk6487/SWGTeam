using System;
class ForLoopExample
{
    public static void Mohit()
    {
        Console.WriteLine("Hello User lets Print Table.\nPlease let me know the value for which you want to Print the table");
        double TabOf = double.Parse(Console.ReadLine()??"0");
        Console.WriteLine("Please Set the Limit in Intger for printing the table");
        int Lim = int.Parse(Console.ReadLine()??"0");
        Console.WriteLine(" Here is the Table for {0}",TabOf);

        for(int i = 1; i<= Lim; i++)
        {
            Console.WriteLine( "{0} X {1} = {2}\a", TabOf, i, (TabOf*i));

        }

        
    }
}

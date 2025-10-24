using System;
class MainFile    
{
    public static void Main()
    {
        int NumbOfUser = 4;
        string[] User = new string[NumbOfUser];

        User[0] = "Sukhminder Kaur";
        User[1] = "Neha Sharma";
        User[2] = "Vikas Chandel";
        User[3] = "Mohit Kumar";

        Console.WriteLine("Swg Team");
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("{0, -5} {1, -20}", "S.No", "| User");
        Console.WriteLine(new string('-', 40));

        int PrintUsers = 0;

        foreach (string Users in User)
        {

            Console.WriteLine("{0, -5} {1, -20}", PrintUsers + 1, "| " + User[PrintUsers]);
            Console.WriteLine(new string('-', 40));
            PrintUsers++;
        }
        Console.WriteLine("Please Enter the Excercise S.No. to See the Result else 0 to Exit\a");
        string choice = Console.ReadLine() ?? "0";
        int update = 0;
        bool valid = int.TryParse(choice, out update);
        if (valid)
        {
            //int choice = Convert.ToInt32(Console.ReadLine());
            //int choice = 8;
            switch (update)
            {
                case 0:
                    Console.WriteLine("Good Bye Happy Learning\a");
                    return;
                case 1:
                    Sukhminder.Csharp();
                    break;
                case 2:
                    Neha.Csharp();
                    break;
                case 3:
                    Vikas.Csharp();
                    break;
                case 4:
                    Mohit.CSharp();
                    break;
            }
        }
    }
}
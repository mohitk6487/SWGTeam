using System;

class Mohit
{
    public static void CSharp()

    {
        int NoOfProg = 9;
        string[] prog = new string[NoOfProg];

        prog[0] = "Read Write and Concatination Operations";
        prog[1] = "IF ELSE Example 1 (Number Negative OR Non Negative)";
        prog[2] = "IF ELSE Example 2 (Arithmetic Operators)";
        prog[3] = "If Else Example 3 (Greatest Among 3 Numbers)";
        prog[4] = "SWITCH & IF ELSE Example (ATM)";
        prog[5] = "SWITCH, DO WHILE Example (C # Cafe)";
        prog[6] = "FOR Loop Example 1 (Table using For Loop)";
        prog[7] = "List Example";

        Console.WriteLine("Select program to run:");
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("{0,-5} | {1,-15}", "S.No.", "Excercise");
        Console.WriteLine(new string('-', 50));

        int m = 0;

        do
        {
            Console.WriteLine("{0,-5} | {1,-15}", m + 1, prog[m]);
            Console.WriteLine(new string('-', 50));
            m++;

        } while (m < prog.Length);
        Console.WriteLine("Please Enter the Excercise S.No. to See the Result else 0 to Exit\a");
        string choice = Console.ReadLine() ?? "0";
        int update = 0;
        bool valid = int.TryParse(choice, out update);
        //bool valid = true;
        //int update = 9;
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
                    ReadWrite.Run();
                    break;
                case 2:
                    IfElseExample.Run();
                    break;
                //case 3:
                //    AritmaticIfElse.Run();
                //    break;
                //case 4:
                //    IfElseTry2.Run();
                //    break;
                //case 5:
                //    ATMusingSwitch.Run();
                //    break;
                //case 6:
                //    CsharpCafeDoWhile.Run();
                //    break;
                //case 7:
                //    ForLoopExample.Run();
                //    break;
                //case 8:
                //    ListExample.Run();
                //    break;
                //case 9:
                //    FruitBasket.Run();
                //    break;
                default:
                    Console.WriteLine("Sorry Invalid choice.\a");
                    CSharp();
                    break;
            }

        }
        else
        {
            Console.WriteLine("Sorry Invalid Choice\a");
            CSharp();

        }

    }

}
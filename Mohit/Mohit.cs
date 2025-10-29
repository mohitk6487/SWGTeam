using System;

namespace Mohit
{

    public class Mohit
    {
        public static void Main()

        {
            //int NoOfProg = 9;
            //string[] prog = new string[NoOfProg];

            //prog[0] = "Read Write and Concatination Operations";
            //prog[1] = "IF ELSE Example 1 (Number Negative OR Non Negative)";
            //prog[2] = "IF ELSE Example 2 (Arithmetic Operators)";
            //prog[3] = "If Else Example 3 (Greatest Among 3 Numbers)";
            //prog[4] = "SWITCH & IF ELSE Example (ATM)";
            //prog[5] = "SWITCH, DO WHILE Example (C # Cafe)";
            //prog[6] = "FOR Loop Example 1 (Table using For Loop)";
            //prog[7] = "List Example";

            //Console.WriteLine("Select program to run:");
            //Console.WriteLine(new string('-', 50));
            //Console.WriteLine("{0,-5} | {1,-15}", "S.No.", "Excercise");
            //Console.WriteLine(new string('-', 50));

            //int m = 0;

            //do
            //{
            //    Console.WriteLine("{0,-5} | {1,-15}", m + 1, prog[m]);
            //    Console.WriteLine(new string('-', 50));
            //    m++;

            //} while (m < prog.Length);
            //Console.WriteLine("Please Enter the Excercise S.No. to See the Result else 0 to Exit\a");
            //string choice = Console.ReadLine() ?? "0";
            //int update = 0;
            //bool valid = int.TryParse(choice, out update);
            bool valid = true;
            int update = 10;
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
                        ReadWriteMohit.Mohit();
                        break;
                    case 2:
                        MohitIfElseExample.Mohit();
                        break;
                    case 3:
                        AritmaticIfElse.Mohit();
                        break;
                    case 4:
                        MohitIfElseTry2.Mohit();
                        break;
                    case 5:
                        ATMusingSwitch.Mohit();
                        break;
                    case 6:
                        MohitCSharpCafeDoWhile.Mohit();
                        break;
                    case 7:
                        ForLoopExample.Mohit();
                        break;
                    case 8:
                        MohitListExample.Mohit();
                        break;
                    case 9:
                        MohitFruitBasket.Mohit();
                        break;
                    case 10:
                        MohitLearningMethods.Mohit();
                        break;
                    default:
                        Console.WriteLine("Sorry Invalid choice.\a");
                        Main();
                        break;
                }

            }
            else
            {
                Console.WriteLine("Sorry Invalid Choice\a");
                Main();

            }

        }

    }
}
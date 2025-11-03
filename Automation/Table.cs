using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sukhi_1
{
    class Table
    {
        public static void Tables()
        {
            string option, input;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello World! Here is the list of programs:");
            String[] options = new string[]
            {
                "1 - Use of Variables, Concatenation and Operators",              "2 - Use of Increment/Decrement operators and Pointer",
                "3 - Open a browser, find element and confirm. Print Title of the browser",
                "4 - Generate random number and verify if 0 or 1",                "5 - Use of switch and break with string match",
                "6 - Use of Nested Loop to print sequence of values for three variables",
                "7 - Printing 1 dimensional array",                               "8 - Printing multi-dimensional array",
                "9 - Use of methonds to print table of a number and subtraction of two numbers with return type"

            };
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine("\t" + options[i]);
            }
            
        ReStart:
            Console.Write("Enter function no. of choice: ");
            input = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("\n\n");
            int num;
            if (int.TryParse(input, out num))
            {

                switch (num)
                {
                    case 1:
                        Variables.Variable();
                        break;
                    case 2:
                        Pointers.PointerVariable();     //Pointer variables value print
                        break;
                    case 3:
                        Browser.BrowserOpen();          //Browser open, locate an element, print title then close
                        break;
                    case 4:
                        IfElse_Switch.IfElse();         //IfElse conditions are executed
                        break;
                    case 5:
                        IfElse_Switch.SwitchBreak();        //call to switch-break program
                        break;
                    case 6:
                        NestedLoops.NestedLoop();           //nested loops whle, do-while, for
                        break;
                    case 7:
                        Arrays_all.Array1D();
                        break;
                    case 8:
                        Arrays_all.Array2D_4D();
                        break;
                    case 9:
                        Methods.Table_sub();
                        break;
                    case 10:
                        Table.Tables();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nInvalid Option.\n\tEnter 'Y' to re-select, any other key to exit: ");
                        string value = Console.ReadLine();
                        Console.ResetColor();
                        if (value == "y" || value == "Y")
                        {
                            goto ReStart;
                        }
                        else
                        {
                            goto Exit;
                        }
                        
                }
            }
            
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nYou have not entered a numeric value. Enter 'Y' to choose again, any other key to exit");
                option = Console.ReadLine();
                goto Verify_choice;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\nDo you want to run another program? Enter 'Y' for yes or any key to exit.");
            option = Console.ReadLine();
        Verify_choice:
            if (option == "y" || option == "Y")
            {
                goto ReStart;
            }

        Exit:
            Console.WriteLine("\n\n\t\t\t\t***Thank you***\n\n");
        }
    }
}

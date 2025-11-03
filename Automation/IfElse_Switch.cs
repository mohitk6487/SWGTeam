using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sukhi_1
{
    class IfElse_Switch
    {
        public static void IfElse()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\tUse of If-Else condition statement");
            Console.ForegroundColor = ConsoleColor.White;
            Random random = new Random();       //Random is a predefined class, whose object can generate a random number out of a given value range
            int num = random.Next(4);       //any random number will be generated within the range of 0-3 and assigned to variable num
            if(num==0)
            {
                Console.WriteLine("\tRandom generated number is: {0}", num);
            }
            else if (num==1)
            {
                Console.WriteLine($"\tRandom generated number is: {num}");
            }
            else
            {
                Console.WriteLine($"\tRandom generated number is neither 0 nor 1 but {num}");
            }
        }
        public static void SwitchBreak()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\tUse of Swtich-Break condition statement");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\tEnter a name: ");
            string name = Console.ReadLine();
            switch (name)
            {
                case "Sukhi":
                    Console.WriteLine("\tYou have entered name of a Lead");
                    break;
                case "Neha":
                    Console.WriteLine("\tYou have entered name of a 2nd lead");
                    break;
                default:
                    Console.WriteLine("\tYou have not entered name of any lead");
                    break;
            }
            
        }
    }
}

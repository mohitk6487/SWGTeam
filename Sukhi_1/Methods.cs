using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sukhi_1
{
    class Methods

    {
        
        public static void Table_sub()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t***Use of Methods, calling methods with return type***");
            Console.ResetColor();
            Console.Write("\tEnter the number to print table of: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Methods.Table_print(num);
            Console.WriteLine("\tEnter two numbers for subtraction: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            //int sub_num=Methods.Subtract(num1, num2);
            Console.WriteLine("\tSubtraction result is: "+(Methods.Subtract(num1, num2)));
        }
        public static void Table_print(int i)
        {
            for(int j=1;j<=10;j++)
            {
                Console.WriteLine("\t\t"+i + " * " + j + " = " + (i * j));
            }
            
        }
        public static int Subtract(int i, int j)
        {
            int sub = i - j;
            return (sub);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sukhi_1
{
    class NestedLoops
    {
        public static void NestedLoop()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t***Use of Nested Loop***");
            Console.ForegroundColor = ConsoleColor.White;
            int i = 0, j = 0, k = 0;        //variables initialised outside the loops then variables' latest values (after increment in the loop) will be retained and conditions will be verified on the latest values
            while(i<3)
            {
                for(;j<4;j++)
                {
                    do
                    {
                        Console.WriteLine($"i is: {i}, j is {j}, k is {k}");
                        k++;
                    } while (k < 5);
                }
                i++;
            }
        }
    }
}

using System;
using System.Diagnostics;

namespace Sukhi_1
{
    class Pointers
    {
        public static void PointerVariable()
        {
            byte a = 255;

            Console.WriteLine("\tValue of byte variable a: " +a);
            a++;
            Console.WriteLine("\tValue of byte variable 'a' after increment: " +a);

            unsafe    //pointer data types can not be used without unsafe command line option and needs to allow through properties for compiler to execute
            {
                int b = 10;
                int* P = &b;  //ampersand and astrisk are pointer data types to show address and value
                Console.WriteLine("\tValue in b: {0}", b);   //{0} is a placeholder to replace the value of 1st variable and that variable doesn't need + symbol
                Console.WriteLine("\tAddress of b: {0}", (int)P);  //Gremlin.Net.Process.Traversal needs to be used, {0} is a placeholder for value
            }

            

        }
    }
}

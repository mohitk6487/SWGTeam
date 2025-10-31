using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
    class Variables
    {
        int y=23;
        public static void Variable()
        {
            int x = 32;     //compile time initilisation of the varialbe x
            Console.WriteLine("\tValue of x (Initilised at compile time):" + x);

            Variables var = new Variables();  //creating object of a class to access the global variable y
            Console.WriteLine("\tValue of y is (Global Varialbe):" + var.y);   //accessing global variable with class object
            Console.Write("\tEnter value for variable z: ");
            int z = Convert.ToInt32(Console.ReadLine()); //runtime initilisation of the variable z
            Console.WriteLine("\n\tValue of z: " + z);

            //Different ways to print the statements with variables
            Debug.WriteLine("Different syntaxes used to display the same result...");
            Debug.WriteLine("Value of x: {0} and Value of z: {1}", x, z);
            Debug.WriteLine("Value of x: " + x + " and Value of z: " + z);
            Debug.WriteLine($"Value of x: {x} and Value of z: {z}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\tString variables and Concatenation");
            Console.ForegroundColor = ConsoleColor.White;
            string s1 = "Name", s2 = "Age", s3 = "Height";      //multiple variable declaration and initilisation in one statement 
            Console.WriteLine("\t"+10 + 20 + s1 + 30 + s2 + s3);    //BODMAS rule followed (Brackets, Orders [Powers and Roots], Division, Multiplication, Addition, Subtraction) 

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\tAssignment Operators behaviour");
            Console.ForegroundColor = ConsoleColor.White;
            int num = 10;
            num += 2;     //it is equivalent to num=num+2
            Console.WriteLine($"\tValue of num after the use of assignment operator '+=': {num}");
        } 
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sukhi_1
{
    class Arrays_all
    {
        public static void Array1D()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t***Use of Arrays***");
            Console.ForegroundColor = ConsoleColor.White;
            int[] num = new int[5];          //Array is an object and collection of elements of similar datatypes, whose index starts from 0
            Random random = new Random();
            Console.Write("\t1D array assigned alphabets are: ");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] = random.Next(1, 9));
            }

        }
        public static void Array2D_4D()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\t\t***Use of 2D and 4D Array (Multi-dimensional)***");
            Console.ForegroundColor = ConsoleColor.White;
            int[,] num1 = new int[3,4];          //2D array
            int[,,,] num2 = new int[2,2,3,5];      //4D array
            int i, j, k, l;
            Random random = new Random();
            Console.Write("\t2D array assigned numbers are: \n");
            for (i=0; i < num1.GetLength(0); i++)
            {
                for (j=0; j < num1.GetLength(1); j++)
                {
                    num1[i, j] = random.Next(1, 50);
                    Console.Write(num1[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\t4D assigned numbers are: ");
            for (i=0; i < num2.GetLength(0); i++)
            {
               
                for (j=0; j < num2.GetLength(1); j++)
                {
                    for (k=0; k < num2.GetLength(2); k++)
                    {
                        for (l=0; l < num2.GetLength(3); l++)
                        {
                            Console.Write((num2[i, j, k, l] = random.Next(1, 50)) + "  ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("----------------y");
            }
        }
    }
}

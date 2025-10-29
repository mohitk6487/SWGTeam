using System;

class MohitIfElseExample
{
    public static void Mohit()
    {
        {
            //Program for Else If
            Console.WriteLine("Let's Find Your No. is Negative or non negative \nEnter Your Number:");
            int EnteredNumber = int.Parse(Console.ReadLine() ?? "0");
            if (EnteredNumber == 0)
            {
                Console.WriteLine("Enterd Number is 0(ZERO), Neither and Odd nor and Even");
            }
            else
            {
                if (EnteredNumber > 0)
                {
                    Console.WriteLine("The Number is Non Negative");
                }
                else
                {
                    Console.WriteLine("Your Number is Negative");
                }

            }

        }
    }
}
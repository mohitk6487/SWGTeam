using System;

class MohitIfElseTry2
{
    public static void Mohit()
    {
        Console.WriteLine("We will be finding Greatest of three number using if else statement\n Please Enter 1st Number:");
        int a = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Please Enter 2nd Number:");
        int b = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Please Enter 2nd Number:");
        int c = int.Parse(Console.ReadLine() ?? "0");
        if (a == b || a == c || b == c)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("All Entred Numbers are Equal");
            }
            else
            {
                if (a == b)
                {
                    if (a > c)
                    {
                        Console.WriteLine("The Third no. is Greatest i.e. {0}", c);
                    }
                    else
                    {
                        Console.WriteLine("As First and second numbers ({0}) are equal and also greater than the third one(1)", a, c);
                    }
                }
                else if (b == c)
                {
                    if (a > c)
                    {
                        Console.WriteLine("The First no. is Greatest i.e. {0}", a);
                    }
                    else
                    {
                        Console.WriteLine("As Second and Third numbers ({0}) are equal and also greater than the First one(1)", a, c);
                    }
                }
                else
                {
                    if (b > c)
                    {
                        Console.WriteLine("The Second no. is Greatest i.e. {0}", b);
                    }
                    else
                    {
                        Console.WriteLine("As First and Third numbers ({0}) are equal and also greater than the First one(1)", a, b);
                    }
                }
            }

        }
        else if (a > b && a > c)
        {
            Console.WriteLine("The First number ({0})is Greatest among {0}, {1} and {2} ", a, b, c);
        }
        else if (a < b && b > c)
        {
            Console.WriteLine("The Second number ({1})is Greatest among {0}, {1} and {2} ", a, b, c);
        }
        else
        {
            Console.WriteLine("The Third number ({2})is Greatest among {0}, {1} and {2} ", a, b, c);
        }
    }
}


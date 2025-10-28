using System;

    class MohitLearningMethods
    {
    public static void Mohit()
    {
        Console.WriteLine("Welcome to the C# Methods Learnig Module Please Specify Your Name: ");
        string Name = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Please Enter First Number:");
        double FirstNumber = DoubleValue();
        Console.WriteLine("Please Enter Second Number:");
        double SecondNumber = DoubleValue();
        string Operation = Operations();
        do
        {
           if (Operation == "1"|| Operation == "SUM")
            {
                
                double Sum = SumIs(FirstNumber, SecondNumber);
                Console.WriteLine($"Hello {Name}, Sum of {FirstNumber} and {SecondNumber} is {Sum}");
                
            }
            else if (Operation == "2" || Operation == "DIFFERENCE")
            {

                double Dif = DifIs(FirstNumber, SecondNumber);
                Console.WriteLine($"Hello {Name}, Difference Between {FirstNumber} and {SecondNumber} is {Dif}");
                
            }
            else if (Operation == "3" || Operation == "COMPARISON")
            {
                Console.WriteLine($"Hello {Name},");
                CompIs(FirstNumber, SecondNumber);
                
            }
            else if (Operation == "4" || Operation == "MULTIPLICATION")
            {
                double Mul = MulIs(FirstNumber, SecondNumber);
                Console.WriteLine($"Hello {Name}, Multiplication of {FirstNumber} and {SecondNumber} is {Mul}");
               
            }
            else if (Operation == "5" || Operation == "DIVISION")
            {
                double Div = DivIs(FirstNumber, SecondNumber);
                Console.WriteLine($"Hello {Name}, Division of {FirstNumber} and {SecondNumber} is {Div}");
               
            }
           else
            {
                Console.WriteLine("Entered Invalid Operation. Please Try Again");
            }
                Operation = Operations();
            
            
        } while (Operation != "0" && Operation != "EXIT");
        Console.WriteLine($"Thankyou {Name}, For Using This System");

        //Console.WriteLine($"Hello {Name}, You Have Entered First Number as {FirstNumber}");
    }
    public static double DoubleValue()
    {
        
        double CheckNumber;
        bool CN = false;
        
        do
        {
            string CNo = Console.ReadLine() ?? string.Empty;
            CN = double.TryParse(CNo, out CheckNumber);
            if (!CN)
            {
                Console.WriteLine("You Have Entred an Invalid Number. Please Enter a Valid Number.");
            }
        } while (!CN);
        return CheckNumber;
    }
    public static double SumIs(double FN, double SN)
    {
        return FN + SN;
    }
    public static double DifIs(double FN, double SN)
    {
        double Dif;
        if (FN > SN)
        {
            Dif = FN - SN;
        }
        else
            Dif = SN - FN;
            return Dif;
    }
    public static void CompIs(double FN, double SN)
    {
        if (FN > SN)
        {
            Console.WriteLine($"{FN} is Greater than {SN}");
        }
        else if(FN < SN)
        {
            Console.WriteLine($"{SN} is Greater than {FN}");
        }
        else if (FN==SN)
        {
            Console.WriteLine($"{FN} is Equal to {SN}");
        }
        
    }
    public static double DivIs(double FN, double SN)
    {
        if (SN == 0)
        {
            Console.WriteLine("Division by zero is not allowed!");
        }
        
        return FN/SN;
    }
    public static double MulIs(double FN, double SN)
    {
        return FN*SN;
    }
    public static string Operations()
    {
        Console.WriteLine("Please Select The Operation.\n1.Sum\n2. Diffrence\n3. Comparison\n4. MultiPlication\n5. Division\n0. Exit");
        string Operation = Console.ReadLine() ?? string.Empty;
        Operation = Operation.ToUpper();
        return Operation;
    }
    }


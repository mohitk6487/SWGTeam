using System;

namespace Mohit.Mohit_Misc
{
    public class FixedDepositCalc
    {
        public InterestResult ShowMenu()
        {
            MohitConvertDataType convert = new MohitConvertDataType();
            Console.WriteLine("Choose Bank:");
            Console.WriteLine("1. SBI");
            Console.WriteLine("2. HDFC");
            Console.Write("Enter your choice: ");

            int choice = convert.StringToInt(Console.ReadLine() ?? "");
            InterestResult result = null;

            switch (choice)
            {
                case 1:
                    SBI sbi = new SBI();
                    Console.Write("Enter Period in Years: ");
                    int sbiPeriod = convert.StringToInt(Console.ReadLine() ?? "");

                    if (sbiPeriod <= 0)
                    {
                        Console.WriteLine("Period must be greater than 0 years.");
                        return null;
                    }

                    result = sbi.GetInterest(sbiPeriod);
                    break;

                case 2:
                    HDFC hdfc = new HDFC();
                    Console.Write("Enter Period in Years: ");
                    int hdfcPeriod = convert.StringToInt(Console.ReadLine() ?? "");

                    if (hdfcPeriod <= 0)
                    {
                        Console.WriteLine("Period must be greater than 0 years.");
                        return null;
                    }

                    result = hdfc.GetInterest(hdfcPeriod);
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    return null;
            }

            Console.WriteLine("\n--- Final Interest Result ---");
            Console.WriteLine($"Period: {result.Period} years");
            Console.WriteLine($"ROI: {result.ROI}%");

            return result;  
        }
    }
}

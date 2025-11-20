using System;
namespace Mohit
{
    public class SBI : BankIntrest
    {
        public Intrest(int period double ROI)
        {
            Console.WriteLine("SBI Intrest Rate is 6%");
            Console.WriteLine("SBI Minimum Lockin Period is 5 years");
            Console.WriteLine("Please Enter Your Period in Years:");
            string input = Console.ReadLine();
            int period = MohitConv
            if (period >= 5)
            {
                Console.WriteLine("You are Eligible for SBI Intrest Rate of 6%");
                return 6.0;
            }
            else
            {
                Console.WriteLine("You are Not Eligible for SBI Intrest Rate of 6%, So, You will get Base Bank Intrest Rate of 4%");
                return base.Bank();
            }
        }
    }
}

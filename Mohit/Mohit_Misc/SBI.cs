using System;

namespace Mohit.Mohit_Misc
{
    public class SBI : BankIntrest
    {
        // SBI overrides the base interest calculation logic
        public override InterestResult GetInterest(int period)
        {
            Console.WriteLine("SBI Interest Rate is 8%");
            Console.WriteLine("SBI Minimum Lock-in Period is 5 years");

            if (period >= 5)
            {
                Console.WriteLine("You are Eligible for SBI Interest Rate of 8%");
                return new InterestResult
                {
                    Period = period,
                    ROI = 8.0
                };
            }
            else
            {
                Console.WriteLine("Not Eligible for SBI 8% Rate.");
                Console.WriteLine("You will get Base Bank Interest Rate of 4%");

                return new InterestResult
                {
                    Period = period,
                    ROI = base.GetIntrestRate()
                };
            }
        }
    }
}

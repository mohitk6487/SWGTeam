using System;

namespace Mohit.Mohit_Misc
{
    public class HDFC : BankIntrest
    {
        // HDFC overrides the base interest calculation logic
        public override InterestResult GetInterest(int period)
        {
            Console.WriteLine("HDFC Interest Rate is 9%");
            Console.WriteLine("HDFC Minimum Lock-in Period is 7 years");

            if (period >= 7)
            {
                Console.WriteLine("You are Eligible for HDFC Interest Rate of 9%");
                return new InterestResult
                {
                    Period = period,
                    ROI = 9.0
                };
            }
            else
            {
                Console.WriteLine("Not Eligible for HDFC 9% Rate.");
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

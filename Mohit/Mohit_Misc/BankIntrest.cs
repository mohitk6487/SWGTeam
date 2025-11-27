using System;
namespace Mohit.Mohit_Misc
{
    public class InterestResult
    {
        public int Period { get; set; }
        public double ROI { get; set; }
    }
    public class BankIntrest
    {
        public virtual double GetIntrestRate()
        {
            Console.WriteLine("Base Bank Intrest Rate is 7.5%");
            return 7.5;
        }
    
    public virtual InterestResult GetInterest(int period)
        {
            Console.WriteLine("Using Base Bank Interest Rate: 7.5%");
            return new InterestResult
            {
                Period = period,
                ROI = 7.5
            };
        }
    }
}


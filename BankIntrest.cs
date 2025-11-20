using System;

namespace Mohit
{
    public class BankIntrest 
    {
        public virtual double GetIntrestRate()
        {
            Console.WriteLine("Base Bank Intrest Rate is 4%");
            return 4.0;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mohit
{
    public class MohitMath
    {

        public static double AddIs(double FN, double SN)
        {
            return FN + SN;
        }
        public static double SubIs(double FN, double SN)
        {
            return FN - SN;
        }
        public static double MulIs(double FN, double SN)
        {
            return FN * SN;
        }
        public static double DivIs(double FN, double SN)
        {
            if (SN == 0)
            {
                Console.WriteLine("Division by zero is not allowed!");
            }

            return FN / SN;
        }
        public static void CompIs(double FN, double SN)
        {
            if (FN > SN)
            {
                Console.WriteLine($"{FN} is Greater than {SN}");
            }
            else if (FN < SN)
            {
                Console.WriteLine($"{SN} is Greater than {FN}");
            }
            else if (FN == SN)
            {
                Console.WriteLine($"{FN} is Equal to {SN}");
            }

        }
        public static void CompoundInt(double Principle, double Time, double ROI, out double Amount, out double Intrest)
            {
                Amount = Principle * Math.Pow(1 + ROI, Time);
                Intrest = Amount - Principle;
            }
        public static void EMI(double LendAmount, double ROI, double TimeInMonths, out double EMI, out double TotalIntrest )
        {
            EMI = (LendAmount * ROI * Math.Pow(1 + ROI, TimeInMonths)) / (Math.Pow(1 + ROI, TimeInMonths) - 1);
            TotalIntrest = (EMI * TimeInMonths) - LendAmount;
        }
    }
}

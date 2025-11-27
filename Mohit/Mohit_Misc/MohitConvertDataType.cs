using System;
namespace Mohit.Mohit_Misc
{
    public class MohitConvertDataType
    {
        public int StringToInt(string ValToCheck)
        {
            int val;
            bool Check = false;
            do
            {
                Check = int.TryParse(ValToCheck, out val);
                if (!Check)
                {
                    Console.WriteLine("Invalid Input! Please Enter Your Values in Integer");
                    ValToCheck = Console.ReadLine() ?? string.Empty;
                }
            } while (!Check);
            return val;
        }
        public double StringToDoub(string ValToCheck)
        {
            double val;
            bool Check = false;
            do
            {
                Check = double.TryParse(ValToCheck, out val);
                if (!Check)
                {
                    Console.WriteLine("Invalid Input! Please Enter valid number");
                    ValToCheck = Console.ReadLine() ?? string.Empty;

                }
            } while (!Check);
            return val;
        }
    }
}

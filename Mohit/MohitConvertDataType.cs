using System;

    class MohitConvertDataType
    {
    public static int StringToInt(string ValToCheck)
    {
        int val;
        bool Check = false;
        do
        {
            Check = int.TryParse(ValToCheck, out val);
            if (!Check) 
            {
                Console.WriteLine("Please Enter Your Values in Integer");
                ValToCheck = Console.ReadLine() ?? string.Empty;
            }
        } while (!Check);
        return val;
    }
    public static double StringToDoub(string ValToCheck)
    {
        double val;
        bool Check = false;
        do
        {
            Check = double.TryParse(ValToCheck, out val);
            if (!Check)
            {
                Console.WriteLine("Please Enter valid Values");
                ValToCheck = Console.ReadLine() ?? string.Empty;
                
            }
        } while (!Check);
        return val;
    }
}

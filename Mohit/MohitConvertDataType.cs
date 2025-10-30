using System;

    class MohitConvertDataType
    {
    public static int StringToInt(string ValToCheck)
    {
        int val;
        bool Check = false;
        while (!Check) ;
        {
            string VTC = Console.ReadLine()?? string.Empty;
            Check = int.TryParse(VTC, out val);
            if (!Check) 
            {
                Console.WriteLine("Please Enter Your Values in Integer");
            }
        } 
        return val;
    }
    public static double StringToDoub(string ValToCheck)
    {
        double val;
        bool Check = false;
        while (!Check) ;
        {
            string VTC = Console.ReadLine() ?? string.Empty;
            Check = double.TryParse(VTC, out val);
            if (!Check)
            {
                Console.WriteLine("Please Enter valid Values");
            }
        } 
        return val;
    }
}

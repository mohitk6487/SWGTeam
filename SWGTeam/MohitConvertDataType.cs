using System;

    class MohitConvertDataType
    {
    public int StringToInt()
    {
        int val;
        bool Check = false;
        do
        {
            string VTC = Console.ReadLine()?? string.Empty;
            Check = int.TryParse(VTC, out val);
            if (!Check) 
            {
                Console.WriteLine("Please Enter Your Values in Integer");
            }
        } while (!Check);
        return val;
    }
    public double StringToDoub()
    {
        double val;
        bool Check = false;
        do
        {
            string VTC = Console.ReadLine() ?? string.Empty;
            Check = double.TryParse(VTC, out val);
            if (!Check)
            {
                Console.WriteLine("Please Enter valid Values");
            }
        } while (!Check);
        return val;
    }
}

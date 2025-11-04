using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohit
{
    public class Calculator : MohitMath
    {
        
        public static void MohitCalculator()
        {
            int option = 7;

            string wish = Greet.Hello();
            string[] Operation = new string[option];
            string[] KeyWord = new string[option];

            Operation[0] = "Addition";
            KeyWord[0] = "ADD";
            Operation[1] = "Subtraction";
            KeyWord[1] = "SUB";
            Operation[2] = "Multiplication";
            KeyWord[2] = "MUL";
            Operation[3] = "Division";
            KeyWord[3] = "DIV";
            Operation[4] = "Comparison";
            KeyWord[4] = "COMP";
            Operation[5] = "Intrest Calculator";
            KeyWord[5] = "INT";
            Operation[6] = "EMI Calculator";
            KeyWord[6] = "EMI";
            void Operations()
            {
                int i = 0;
                Console.WriteLine("{0, -5} {1, -20} {2, -35}", "S.NO.", "| Operation", "| Key Word");
                foreach (string fruit in Operation)
                {

                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("{0, -5} {1, -20} {2, -35}", i + 1, "| " + Operation[i], "| " + KeyWord[i]);
                    i++;
                }
            }
            Console.WriteLine("====================Welcome to C# Calculator===================");

            Console.WriteLine("Please let me know your salutation");
            String Salutation = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Please let me know your name.");
            String UserName = Console.ReadLine()?? string.Empty;

            Console.WriteLine($"Hello {Salutation} {UserName} {wish}, Welcome Again");
            Console.WriteLine("Please Select the opeartion You want to Perform");

            Operations();
            Console.WriteLine("You can else write 0 to Exit after any operation");
            String PerfOperation = Console.ReadLine() ?? string.Empty;
            PerfOperation = PerfOperation.Trim();
            PerfOperation = PerfOperation.Length >=3 ? PerfOperation.Substring(0,3) : PerfOperation;
            PerfOperation = PerfOperation.ToUpper();


            do
            {
                if (PerfOperation == "1" || PerfOperation == "ADD")
                {
                    Console.WriteLine("Please Enter First Number: ");
                    String FirstNumber = Console.ReadLine() ?? string.Empty;
                    double FN = MohitConvertDataType.StringToDoub(FirstNumber);
                    Console.WriteLine("Please Enter Second Number: ");
                    String SecondNumber = Console.ReadLine() ?? string.Empty;
                    double SN = MohitConvertDataType.StringToDoub(SecondNumber);
                    double Sum = AddIs(FN, SN);
                    Console.WriteLine($"Hello {Salutation} {UserName}, The Sum of {FN} and {SN} is:{Sum}");

                }
                else if (PerfOperation == "2" || PerfOperation == "SUB")
                {
                    Console.WriteLine("Please Enter First Number: ");
                    String FirstNumber = Console.ReadLine() ?? string.Empty;
                    double FN = MohitConvertDataType.StringToDoub(FirstNumber);
                    Console.WriteLine("Please Enter Second Number: ");
                    String SecondNumber = Console.ReadLine() ?? string.Empty;
                    double SN = MohitConvertDataType.StringToDoub(SecondNumber);
                    double Dif = MohitMath.SubIs(FN, SN);
                    Console.WriteLine($"Hello {Salutation} {UserName}, Subtracting {FirstNumber} from {SecondNumber} is:{Dif}");

                }
                else if (PerfOperation == "3" || PerfOperation == "MUL")
                {
                    Console.WriteLine("Please Enter First Number: ");
                    String FirstNumber = Console.ReadLine() ?? string.Empty;
                    double FN = MohitConvertDataType.StringToDoub(FirstNumber);
                    Console.WriteLine("Please Enter Second Number: ");
                    String SecondNumber = Console.ReadLine() ?? string.Empty;
                    double SN = MohitConvertDataType.StringToDoub(SecondNumber);
                    double Mul = MohitMath.MulIs(FN, SN);
                    Console.WriteLine($"Hello {Salutation} {UserName}, The Product of {FirstNumber} and {SecondNumber} is:{Mul}");

                }
                else if (PerfOperation == "4" || PerfOperation == "DIV")
                {
                    Console.WriteLine("Please Enter First Number: ");
                    String FirstNumber = Console.ReadLine() ?? string.Empty;
                    double FN = MohitConvertDataType.StringToDoub(FirstNumber);
                    Console.WriteLine("Please Enter Second Number: ");
                    String SecondNumber = Console.ReadLine() ?? string.Empty;
                    double SN = MohitConvertDataType.StringToDoub(SecondNumber);
                    double Div = MohitMath.DivIs(FN, SN);
                    Console.WriteLine($"Hello {Salutation} {UserName}, Deviding {SecondNumber} by {FirstNumber} is:{Div}");

                }
                else if (PerfOperation == "5" || PerfOperation == "COM")
                {
                    Console.WriteLine("Please Enter First Number: ");
                    String FirstNumber = Console.ReadLine() ?? string.Empty;
                    double FN = MohitConvertDataType.StringToDoub(FirstNumber);
                    Console.WriteLine("Please Enter Second Number: ");
                    String SecondNumber = Console.ReadLine() ?? string.Empty;
                    double SN = MohitConvertDataType.StringToDoub(SecondNumber);
                   
                }
                else if (PerfOperation == "6" || PerfOperation == "INT")
                {
                    Console.WriteLine("Please Enter Principal Amount which you want to deposit: ");
                    String Pri = Console.ReadLine() ?? string.Empty;
                    double Principal = MohitConvertDataType.StringToDoub(Pri);
                    Console.WriteLine("Please Enter Time in Years for which You want to Calculate Intrest: ");
                    String Time = Console.ReadLine() ?? string.Empty;
                    double TimePeriod = MohitConvertDataType.StringToDoub(Time);
                    Console.WriteLine("Please Enter Provided Rate of Intrest for which You want to Calculate Intrest: ");
                    String ROI = Console.ReadLine() ?? string.Empty;
                    double RateOfIntrest = MohitConvertDataType.StringToDoub(ROI);
                    MohitMath.CompoundInt(Principal, TimePeriod, RateOfIntrest, out double Amount, out double Intrest);
                    Console.WriteLine($"Hello {Salutation} {UserName}, For Your Amount {Principal}, if you deposit for {TimePeriod} Years at Rate of Intrest of {RateOfIntrest}.");
                    Console.WriteLine($"You will get Total Amont of Rs. {Amount:F2}");
                    Console.WriteLine($"You Will Earn Intrest of Rs. {Intrest:F2}");

                }
                else if (PerfOperation == "7" || PerfOperation == "EMI")
                {
                    Console.WriteLine("Please Enter Desired Loan Amount ");
                    String Pri = Console.ReadLine() ?? string.Empty;
                    double Principal = MohitConvertDataType.StringToDoub(Pri);
                    Console.WriteLine($"Please Enter Time in Months for which You want to Calculate EMI for Amount Rs. {Principal}");
                    String Time = Console.ReadLine() ?? string.Empty;
                    double TimePeriod = MohitConvertDataType.StringToDoub(Time);
                    Console.WriteLine($"Please Enter Expected Rate of Intrest for which You want to Calculate EMI fro Rs. {Principal} fro {TimePeriod} months.");
                    String ROI = Console.ReadLine() ?? string.Empty;
                    double RateOfIntrest = MohitConvertDataType.StringToDoub(ROI);
                    MohitMath.EMI(Principal, TimePeriod, RateOfIntrest, out double Amount, out double Intrest);
                    Console.WriteLine($"Hello {Salutation} {UserName}, For Your Amount {Principal}, if you deposit for {TimePeriod} Years at Rate of Intrest of {RateOfIntrest}.");
                    Console.WriteLine($"Your Expected EMI will be Rs. {Amount:F2}");
                    Console.WriteLine($"You Will be paying Rs. {Intrest:F2} as Intrest");
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Input");
                }
                Operations();
                PerfOperation = Console.ReadLine() ?? string.Empty;
                PerfOperation = PerfOperation.Trim().ToUpper();

            } while (PerfOperation != "0" && PerfOperation != "EXI");
            wish = Greet.Hello();
            Console.WriteLine($"{wish} {Salutation} {UserName} for Using C# Calculator. Have a nice day Ahead");

        }
    }
}

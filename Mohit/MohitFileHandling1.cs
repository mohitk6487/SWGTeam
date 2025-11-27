using Mohit.Mohit_Misc;
using OpenQA.Selenium.DevTools.V140.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mohit
{
    public class MohitFileHandling1
    {
        private static readonly string Csvpath = "employee.csv";
        public static void CreateCSV()
        {
            if (File.Exists(Csvpath))
            {
                return;
            }
            else
            {
                //Console.WriteLine("This is Mohit File Handling 1 class.");
                string header = "EmployeeID,FirstName,LastName,Email,Phone,Designation,BaseSalary,VariablePay";
                try
                {
                    File.WriteAllText(Csvpath, header + Environment.NewLine);
                    //Console.WriteLine($"Employee.csv file created at path: {Path.GetFullPath(Csvpath)}");
                }
                catch (Exception error)
                {
                    Console.WriteLine($"Error creating file: {error.Message}");
                }
            }


        }
        public static void AddEmployee(string id, string first, string last, string email, string phone, string designation, double baseSalary, double variablePay) 
        { 
            string record = $"{id},{first},{last},{email},{phone},{designation},{baseSalary},{variablePay}"; 
            File.AppendAllText(Csvpath, record + Environment.NewLine); 
        }
        public static void EnterEmployeeDetails()
        {
            while (true)
            {
                Console.WriteLine("Do You Want to Enter new Emplyee details? Yes/No");
                string AddDetailChoice = Console.ReadLine() ?? String.Empty;
                AddDetailChoice = AddDetailChoice.ToUpper();
            
                if (AddDetailChoice.Equals("YES"))
                {
                    Console.WriteLine("Enter Employee Details:");
                    Console.Write("Employee ID: ");
                    string id = Console.ReadLine() ?? "";
                    Console.Write("First Name: ");
                    string first = Console.ReadLine() ?? "";
                    Console.Write("Last Name: ");
                    string last = Console.ReadLine() ?? "";
                    Console.Write("Email: ");
                    string email = Console.ReadLine() ?? "";
                    Console.Write("Phone: ");
                    string phone = Console.ReadLine() ?? "";
                    Console.Write("Designation: ");
                    string designation = Console.ReadLine() ?? "";
                    Console.Write("Base Salary: ");
                    double baseSalary = Convert.ToDouble(Console.ReadLine() ?? "0");
                    Console.Write("Variable Pay: ");
                    double variablePay = Convert.ToDouble(Console.ReadLine() ?? "0");
                    AddEmployee(id, first, last, email, phone, designation, baseSalary, variablePay);
                    Console.WriteLine("Employee details added successfully.");
                }
                else if (AddDetailChoice.Equals("NO"))
                {
                    Console.WriteLine("Exititng Program!");
                    break;

                }
                else
                {
                    Console.WriteLine("Invalid Choice!");
                }
            }
            
        }
        public static void GetEmployeeDetails()
        {
            if (!File.Exists(Csvpath))
            {
                Console.WriteLine("CSV file does not exist. Please create the file first.");
                return;
            }
            else
            {
                try
                {
                    string[] records = File.ReadAllLines(Csvpath);
                    if (records.Length == 0)
                        {
                            Console.WriteLine("No employee records found.");
                            return;
                        }
                    var table = records
                        .Where(records => !string.IsNullOrWhiteSpace(records))
                        .Select(records => records.Split(','))
                        .ToList();

                }
                catch (Exception error)
                {
                    Console.WriteLine($"Error reading file: {error.Message}");
                }
            }
        }
        public static void FileHandlingExample()
        {
            MohitConvertDataType Convertor = new MohitConvertDataType();
            while (true)
            {
                Console.WriteLine("Mohit File Handling Example:");
                Console.WriteLine("Please Select an Option:");
                Console.WriteLine("1. Create CSV File");
                Console.WriteLine("2. Add Employee Details");
                Console.WriteLine("3. Get Employee Details");
                int Choice = Convertor.StringToInt(Console.ReadLine() ?? "0");
                switch (Choice)
                {
                    case 1:
                        CreateCSV();
                        Console.WriteLine("CSV File Created Successfully.");
                        break;
                    case 2:
                        EnterEmployeeDetails();
                        break;
                    case 3:
                        GetEmployeeDetails();
                        break;
                    default:
                        Console.WriteLine("Exiting File Handling Example.");
                        return;
                }

            }
        }


    }
}
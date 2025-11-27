using Mohit.Mohit_Misc;
using System;
using System.Windows.Markup;


namespace Mohit
{
    public class Employee
    {
        public int EmpId   { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public string Desigantion { get; set; }
        public string Email { get; set; }
    }
    public class MohitListOperations 
    {
        public static void MohitListOperation() 
        {
            List<Employee> Employees = new List<Employee>()
            {
               new Employee {EmpId = 1011, EmpName = "Mohit Kumar", Salary= 50000, Desigantion = "Sales Executive", Email = "mohit.kumar@abc.com" },
               new Employee {EmpId = 1012, EmpName = "Anita Singh", Salary= 70000, Desigantion = "Sales Manager", Email = "anitasingh@abc.com" },
               new Employee {EmpId = 1013, EmpName = "Mohit Sharma", Salary= 70000, Desigantion = "Sales Executive", Email = "rakeshkumar@abc.com" },
               new Employee {EmpId = 1014, EmpName = "Sunita Verma", Salary= 40000, Desigantion = "Accountant", Email = "sunitaverma@abc.com" },
               new Employee {EmpId = 1015, EmpName = "Vikram Gupta", Salary= 90000, Desigantion = "Medical Supervisor", Email = "vikramgupta@abc.com"}
            };
            Console.WriteLine("Employee Details:");
            int m = 0;

            do
            {
                var emp = Employees[m];
                Console.WriteLine($"{emp.EmpId}|{emp.EmpName}|{emp.Salary}|{emp.Desigantion}|{emp.Email}");
                m++;
            } while (m < Employees.Count);

            MohitConvertDataType convertDataType = new MohitConvertDataType();

            Console.WriteLine("Please Enter \n1. To Search By Employee ID.\n2. To Search By Employee Name.\n3. To Search By Salary.\n4. To Search by Designation.\n5. Search by Email.");
            int choice = convertDataType.StringToInt(Console.ReadLine()?? String.Empty);

            if (choice == 1)
            {
                Console.WriteLine("Enter Employee ID to search:");
                int SearchID = convertDataType.StringToInt(Console.ReadLine() ?? String.Empty);

                var FoundEmp = Employees.Find(e => e.EmpId == SearchID);

                if (FoundEmp != null)
                {
                    Console.WriteLine("Employee Found:");
                    Console.WriteLine($"{FoundEmp.EmpId}|{FoundEmp.EmpName}|{FoundEmp.Salary}|{FoundEmp.Desigantion}|{FoundEmp.Email}");
                }
                else
                {
                    Console.WriteLine("Employee Not Found.");
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter Employee Name to Search:");
                string SearchName = Console.ReadLine() ?? String.Empty;
                var FoundEmp = Employees.FindAll(e => e.EmpName.Contains(SearchName, StringComparison.OrdinalIgnoreCase));
                if (FoundEmp.Count > 0)
                {
                    Console.WriteLine("Employee(s) Found:");
                    foreach (var emp in FoundEmp)
                    {
                        Console.WriteLine($"{emp.EmpId}|{emp.EmpName}|{emp.Salary}|{emp.Desigantion}|{emp.Email}");
                    }
                }
                else
                {
                    Console.WriteLine("Employee Not Found.");

                }
            }
            else if ( choice == 3)

            {
                Console.WriteLine("Enter Salary to Search:");
                double SearchSalary = convertDataType.StringToDoub(Console.ReadLine() ?? String.Empty);
                Console.WriteLine($"1. To List Employees More Than {SearchSalary}.\n2. To List Employees Less Than {SearchSalary}");
                int SalaryChoice = convertDataType.StringToInt(Console.ReadLine() ?? String.Empty);
                if (SalaryChoice == 1)
                {
                    var FoundEmpbysal = Employees.FindAll(e => e.Salary >= SearchSalary);
                    if (FoundEmpbysal.Count > 0)
                    {
                        Console.WriteLine("Employee(s) Found:");
                        foreach (var emp in FoundEmpbysal)
                        {
                            Console.WriteLine($"{emp.EmpId}|{emp.EmpName}|{emp.Salary}|{emp.Desigantion}|{emp.Email}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Employees Found.");
                    }
                }
                else if (SalaryChoice == 2)
                {
                    var FoundEmpbysal = Employees.FindAll(e => e.Salary <= SearchSalary);
                    if (FoundEmpbysal != null && FoundEmpbysal.Count > 0)
                    {
                        Console.WriteLine("Employee(s) Found:");
                        foreach (var emp in FoundEmpbysal)
                        {
                            Console.WriteLine($"{emp.EmpId}|{emp.EmpName}|{emp.Salary}|{emp.Desigantion}|{emp.Email}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Employees Found.");
                    }
                }
                
            }
            else if (choice == 4)
            {
                Console.WriteLine("Enter Designation to Search:");
                string SearchDesignation = Console.ReadLine() ?? String.Empty;
                var FoundEmp = Employees.FindAll(e => e.Desigantion.Contains(SearchDesignation, StringComparison.OrdinalIgnoreCase));
                if (FoundEmp != null && FoundEmp.Count > 0)
                {
                    Console.WriteLine("Employee(s) Found:");
                    foreach (var emp in FoundEmp)
                    {
                        Console.WriteLine($"{emp.EmpId}|{emp.EmpName}|{emp.Salary}|{emp.Desigantion}|{emp.Email}");
                    }
                }
                else
                {
                    Console.WriteLine("Employee Not Found.");
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Enter Email to Search:");
                string SearchEmail = Console.ReadLine() ?? String.Empty;
                var FoundEmp = Employees.FindAll(e => e.Email.Equals(SearchEmail, StringComparison.OrdinalIgnoreCase));

                if (FoundEmp.Count > 0)
                {
                    Console.WriteLine("Employee(s) Found:");
                    foreach (var emp in FoundEmp)
                    {
                        Console.WriteLine($"{emp.EmpId}|{emp.EmpName}|{emp.Salary}|{emp.Desigantion}|{emp.Email}");
                    }
                }
                else
                {
                    Console.WriteLine("Employee Not Found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Choice.");
            }

        }
    }
}
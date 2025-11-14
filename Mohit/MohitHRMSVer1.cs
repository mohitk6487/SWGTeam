using System;


namespace Mohit
{
    public class Employee
    {
        public string? FirstName;
        public string? LastName;
        public string? email;
        public string? phone;
        public string? Designation;
        public int EmployeeID;
        public double BaseSalary;
        public double VariablePay;

        
        public void EmployeeCompensation()
        {
            //Console.WriteLine("Welcome to Mohit HRMS Ver 1.0");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Employee Details for Employee Id {EmployeeID} are as follows:");
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("Designation: " + Designation);       
        }

        public class EmployeeGroup1 : Employee
        {
            public double TargetSale;
            public double AchievedSale;
            public double DaysWorked;
            public double CalculateBonus()
            {
                
                    double bonus = (AchievedSale/TargetSale) * VariablePay;
                    if (bonus > VariablePay)
                    {
                        Console.WriteLine($"Great Job! You have earned an extra 5% bonus on your Variable Pay: {0.05*bonus}");
                        bonus = VariablePay+(0.05*bonus);
                        bonus = Math.Round(bonus, 2);
                        Console.WriteLine($"Bonus after extra 5%: {bonus}");

                    }
                    BaseSalary = (DaysWorked/30)*BaseSalary;
                    bonus = Math.Round(bonus, 2);
                    Console.WriteLine($"Base Salary after considering Days Worked: {BaseSalary}");
                    Console.WriteLine($"Calculated Variable: {bonus}");
                    double TotalCompensation = BaseSalary + bonus;
                    TotalCompensation = Math.Round(TotalCompensation, 2);
                    return TotalCompensation;

            }
        }
        public class EmployeeGroup2 : Employee
        {
            public double AssignedTask;
            public double AchievedTask;
            public double DaysWorked;
            public double CalculateBonus()
            {

                double bonus = (AchievedTask / AssignedTask) * VariablePay;
                if (bonus > VariablePay)
                {
                    Console.WriteLine($"Great Job! You have earned an extra 5% bonus on your Variable Pay: {0.05 * bonus}");
                    bonus = VariablePay + (0.05 * bonus);
                    bonus = Math.Round(bonus, 2);
                    Console.WriteLine($"Bonus after extra 5%: {bonus}");
                }
                BaseSalary = (DaysWorked / 30) * BaseSalary;
                bonus = Math.Round(bonus, 2);
                Console.WriteLine($"Base Salary after considering Days Worked: {BaseSalary}");
                Console.WriteLine($"Calculated Variable: {bonus}");
                double TotalCompensation = BaseSalary + bonus;
                TotalCompensation = Math.Round(TotalCompensation, 2);
                return TotalCompensation;

            }
        }

        public class MohitHRMSVer1
        {
            public static void MohitHRMSVer()
            {
                Employee[] emp = new Employee[5];


                emp[0] = new EmployeeGroup1
                {
                    FirstName = "Raman",
                    LastName = "Singh",
                    email = "raman.singh@abc.com",
                    phone = "+919738001210",
                    EmployeeID = 1210,
                    Designation = "Sales Executive",
                    BaseSalary = 50000,
                    VariablePay = 20000


                };
                emp[1] = new EmployeeGroup1
                {
                    FirstName = "Krishan",
                    LastName = "Yadav",
                    email = "krishan.yadav@abc.com",
                    phone = "+919738001211",
                    EmployeeID = 1211,
                    Designation = "Sales Executive",
                    BaseSalary = 45000,
                    VariablePay = 18000

                };
                emp[2] = new EmployeeGroup1
                {
                    FirstName = "Namit",
                    LastName = "Jian",
                    email = "namit.jain@abc.com",
                    phone = "+919738001212",
                    EmployeeID = 1212,
                    Designation = "Sales Head",
                    BaseSalary = 75000,
                    VariablePay = 25000


                };
                emp[3] = new EmployeeGroup2
                {
                    FirstName = "Vani",
                    LastName = "Ahuja",
                    email = "vani.ahuja@abc.com",
                    phone = "+919738001213",
                    EmployeeID = 1213,
                    Designation = "Acountant",
                    BaseSalary = 25000,
                    VariablePay = 10000


                };
                emp[4] = new EmployeeGroup2
                {
                    FirstName = "Kartik",
                    LastName = "Sharma",
                    email = "kartik.sharma@abc.com",
                    phone = "+919738001214",
                    EmployeeID = 1214,
                    Designation = "Medical Supervisor",
                    BaseSalary = 85000,
                    VariablePay = 40000

                };
                string wish = Greet.Hello();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(wish + " Welcome to Mohit HRMS Ver 1.0");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Please Let us know your Name:");
                string? name = Console.ReadLine();
                Console.WriteLine($"{wish} {name}, Please Enter The Employee ID to Calculate Compensation Details:");
                string? empIDInput = Console.ReadLine() ?? string.Empty;
                int empID = MohitConvertDataType.StringToInt(empIDInput);
                
                bool found = false;
                for(int i=0; i<emp.Length; i++)
                {
                    if(emp[i] != null && emp[i].EmployeeID == empID)
                    {
                        emp[i].EmployeeCompensation();
                        if(emp[i] is EmployeeGroup1 group1)
                        {
                            found = true;
                            Console.WriteLine("Please Enter No. of Working Days");
                            string? daysWorkedInput = Console.ReadLine() ?? string.Empty;
                            group1.DaysWorked = MohitConvertDataType.StringToDoub(daysWorkedInput);
                            Console.WriteLine("Target Sale:");
                            string? targetSaleInput = Console.ReadLine() ?? string.Empty;
                            group1.TargetSale = MohitConvertDataType.StringToDoub(targetSaleInput);
                            Console.WriteLine("Achieved Sale:");    
                            string? achievedSaleInput = Console.ReadLine() ?? string.Empty;
                            group1.AchievedSale = MohitConvertDataType.StringToDoub(achievedSaleInput);
                            Console.WriteLine("Total Compensation: " + group1.CalculateBonus());
                        }
                        else if(emp[i] is EmployeeGroup2 group2)
                        {
                            Console.WriteLine("Please Enter No. of Working Days");
                            string? daysWorkedInput = Console.ReadLine() ?? string.Empty;
                            group2.DaysWorked = MohitConvertDataType.StringToDoub(daysWorkedInput);
                            Console.WriteLine("Assigned Task:");
                            string? assignedTaskInput = Console.ReadLine() ?? string.Empty;
                            group2.AssignedTask = MohitConvertDataType.StringToDoub(assignedTaskInput);
                            Console.WriteLine("Achieved Task:");
                            string? achievedTaskInput = Console.ReadLine() ?? string.Empty;
                            group2.AchievedTask = MohitConvertDataType.StringToDoub(achievedTaskInput);
                            Console.WriteLine("Total Compensation: " + group2.CalculateBonus());
                        }
                        break;

                    }
                    

                }
                if (!found)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Employee not found");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}

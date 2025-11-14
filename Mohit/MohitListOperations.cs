using System;


namespace Mohit
{
    public class MohitListOperations
    {
        public static void MohitListOperation() 
        {
            List<String> Employees = new List<string>();
           
            Employees.Add("1011,Mohit Kumar,50000, Sales Executive, mohit.kumar@abc.com");
            Employees.Add("1012,Anita Singh,70000, Sales Manager, anita.singh@abc.com");
            Employees.Add("1013,Rakesh Sharma,70000, Sales Executive,rakesh.sharma@abc.com");
            Employees.Add("1014,Sunita Verma,40000, Accountant,sunita.verma@abc.com ");
            Employees.Add("1015,Vikram Gupta,90000, Medical Supervisor,vikram.gupta@abc.com");
            
            Console.WriteLine("Employee Details:");
            int m = 0;

            do
            {
                Console.WriteLine(Employees[m]);
                m++;
            } while (m < Employees.Count);

        }
    }
}

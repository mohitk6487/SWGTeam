using System;
using System.IO;

namespace Mohit
{
    class MohitFileHandling
    {
        public static void FileHandlingDemo()
        {
            string filePath = "EmployeeData.csv";
            // Writing to a file
            //using (StreamWriter writer = new StreamWriter(filePath))
            //{
            //    writer.WriteLine("EmployeeID,FirstName,LastName,Email,Phone,Designation,BaseSalary,VariablePay");
            //    writer.WriteLine("1011,Mohit, Kumar, mohit.kumar@abc.com,9876501011,Sales Executive,50000,10000");
            //    writer.WriteLine("1012,Anita, Singh,anita.singh@abc.com,9876501012,Sales Manager,70000,15000");
            //    writer.WriteLine("1013, Rakesh, Sharma,rakesh.sharma@abc.com,9876501013,Sales Executive,70000,15000");
            //    writer.WriteLine("1014, Sunita, Verma,sunita.verma@abc.com,9876501014,Accountant,40000,8000");
            //    writer.WriteLine("1015, Vikram, Gupta,vikram.gupta@abc.com,9876501015,Medical Supervisor,90000,20000");
            //}
            //Console.WriteLine("Employee data written to file successfully.");

            // Reading from a file
            using (StreamReader reader = new StreamReader(filePath))
            {
                string headerLine = reader.ReadLine(); // Read header line
                Console.WriteLine(headerLine);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}

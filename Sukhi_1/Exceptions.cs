using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Exceptions
    {
        public static void ExceptionHandling()
        {
            try
            {
                Console.WriteLine("Enter numerator:");
                int numerator = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter denominator:");
                int denominator = Convert.ToInt32(Console.ReadLine());
            if (denominator==0)
            {
                throw new Exception("Denominator is zero.(This is a custom exception message.)");

            }
            int result = numerator / denominator;
                Console.WriteLine($"Result: {result}");

        }
       
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Invalid input format. Please enter numeric values. " + ex.Message);
        }
        catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution of the try-catch block is complete.");
            }

    }
}


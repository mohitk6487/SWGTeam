using System;

    class VikasElseIfing
    {
        public static void P3()
        {
            Console.WriteLine("Enter your Marks (0-100): ");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (marks > 100 || marks < 0)
            {
                Console.WriteLine("Invalid input! Marks must be between 0 and 100.");
                Console.WriteLine("Grade: Fail");
            }
            else if (marks >= 90)
            {
                Console.WriteLine("Grade: A+ (Pass)");
            }
            else if (marks >= 75)
            {
                Console.WriteLine("Grade: A (Pass)");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade: B (Pass)");
            }
            else if (marks >= 45)
            {
                Console.WriteLine("Grade: C (Pass)");
            }
            else if (marks >= 33)
            {
                Console.WriteLine("Grade: D (Pass)");
            }
            else
            {
                Console.WriteLine("Grade: Fail");
            }
        }
    }

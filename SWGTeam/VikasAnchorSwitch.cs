using System;


    class VikasAnchorSwitch
    {
        public static void P4()
        {
            Console.WriteLine("Enter your Marks (0-100): ");
            int marks = Convert.ToInt32(Console.ReadLine());
            switch (marks/10)
            {
                case 9:
                    Console.WriteLine("Grade is : A+");
                    break;
                case 7:
                    Console.WriteLine("Grade is  : A");
                    break;
                case 5:
                    Console.WriteLine("Grade is  : B");
                    break;
                case 4:
                    Console.WriteLine("Grade is  : C");
                    break;
                default:
                    Console.WriteLine("Grade is : Fail");
                    break;
            }
        }

            
        
    }


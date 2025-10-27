using System;

    class VikasElf
    {
        public static void P5()
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your Marks (0–100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            string grade; // variable to store grade

            if (marks > 100 || marks < 0)
            {
                grade = "Invalid (Fail)";
            }
            else
            {
                switch (marks / 10)
                {
                    case 10: // for 100
                    case 9:
                        grade = "A+ (Pass)";
                        break;
                    case 8:
                        grade = "A (Pass)";
                        break;
                    case 7:
                        grade = "B (Pass)";
                        break;
                    case 6:
                        grade = "C (Pass)";
                        break;
                    case 5:
                        grade = "D (Pass)";
                        break;
                    case 4:
                        grade = "E (Pass)";
                        break;
                    default:
                        grade = "Fail";
                        break;
                }
            }

            Console.WriteLine($"Grade is: {grade}, Marks: { marks}");
        }
    }



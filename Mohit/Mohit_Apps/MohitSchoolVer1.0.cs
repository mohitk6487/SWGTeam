using System;
namespace Mohit.Mohit_Apps
{
    public class Student
    {
        // ---------- Encapsulated Fields ----------
        private string? name;
        private int rollNumber;
        private double attendance;
        private double english, hindi, math, science, social;

        // ---------- Public Getters and Setters ----------
        public string Name
        {
            get { return name!; }
            set { name = value; }
        }

        public int RollNumber
        {
            get { return rollNumber; }
            set { rollNumber = value; }
        }

        public double Attendance
        {
            get { return attendance; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Invalid Attendance Entered! Setting to 0.");
                    attendance = 0;
                }
                else
                {
                    attendance = value;
                }
            }
        }

        public double English
        {
            get { return english; }
            set { english = ValidateMark(value); }
        }

        public double Hindi
        {
            get { return hindi; }
            set { hindi = ValidateMark(value); }
        }

        public double Math
        {
            get { return math; }
            set { math = ValidateMark(value); }
        }

        public double Science
        {
            get { return science; }
            set { science = ValidateMark(value); }
        }

        public double Social
        {
            get { return social; }
            set { social = ValidateMark(value); }
        }

        // ---------- Helper for marks ----------
        private double ValidateMark(double m)
        {
            if (m < 0 || m > 100)
            {
                Console.WriteLine("Invalid Marks Entered! Setting to 0.");
                return 0;
            }
            return m;
        }

        // ---------- Result Calculation ----------
        public void CalculateResult()
        {
            Console.WriteLine($"\n--- Result of {Name} (Roll: {RollNumber}) ---");

            if (Attendance < 70)
            {
                Console.WriteLine("Status: FAIL (Attendance less than 70%)");
                return;
            }

            double total = English + Hindi + Math + Science + Social;
            double percentage = total / 5;

            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Percentage: {percentage}%");

            if (percentage >= 33)
                Console.WriteLine("Status: PASS");
            else
                Console.WriteLine("Status: FAIL");
        }
    }


    public class MOhitSchoolVer1
    {
        public static void SchoolApp()
        {
            // ----------- Students Predefined -----------
            Student[] students = new Student[4];

            students[0] = new Student() { Name = "Raman", RollNumber = 101 };
            students[1] = new Student() { Name = "Anita", RollNumber = 102 };
            students[2] = new Student() { Name = "Mohit", RollNumber = 103 };
            students[3] = new Student() { Name = "Richa", RollNumber = 104 };

            // ----------- Input Values from User -----------
            foreach (Student st in students)
            {
                Console.WriteLine($"\nEnter details for {st.Name} (Roll: {st.RollNumber})");

                Console.Write("Attendance (%): ");
                st.Attendance = Convert.ToDouble(Console.ReadLine());

                Console.Write("English Marks: ");
                st.English = Convert.ToDouble(Console.ReadLine());

                Console.Write("Hindi Marks: ");
                st.Hindi = Convert.ToDouble(Console.ReadLine());

                Console.Write("Math Marks: ");
                st.Math = Convert.ToDouble(Console.ReadLine());

                Console.Write("Science Marks: ");
                st.Science = Convert.ToDouble(Console.ReadLine());

                Console.Write("Social Studies Marks: ");
                st.Social = Convert.ToDouble(Console.ReadLine());

                // Show Result
                st.CalculateResult();
            }
        }
    }
}

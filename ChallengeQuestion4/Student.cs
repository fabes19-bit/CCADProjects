using System;

namespace ChallengeQuestion4
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; } = string.Empty;
        public double PhysicsMarks { get; set; }
        public double ChemistryMarks { get; set; }
        public double ComputerApplicationMarks { get; set; }

        public double TotalMarks => PhysicsMarks + ChemistryMarks + ComputerApplicationMarks;

        public double Percentage => TotalMarks / 3.0;

        public string Division
        {
            get
            {
                if (Percentage >= 60)
                    return "First";
                else if (Percentage >= 48)
                    return "Second";
                else if (Percentage >= 36)
                    return "Pass";
                else
                    return "Fail";
            }
        }

        public void DisplayReport()
        {
            Console.WriteLine($"Roll No : {RollNo}");
            Console.WriteLine($"Name of Student : {Name}");
            Console.WriteLine($"Marks in Physics : {PhysicsMarks}");
            Console.WriteLine($"Marks in Chemistry : {ChemistryMarks}");
            Console.WriteLine($"Marks in Computer Application : {ComputerApplicationMarks}");
            Console.WriteLine($"Total Marks = {TotalMarks}");
            Console.WriteLine($"Percentage = {Percentage:F2}");
            Console.WriteLine($"Division = {Division}");
        }
    }
}

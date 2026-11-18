using System;

namespace ChallengeQuestion4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Input the Roll Number of the student : ");
            student.RollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Name of the Student : ");
            student.Name = Console.ReadLine() ?? "";

            Console.Write("Input the marks of Physics, Chemistry and Computer Application : ");
            string marksInput = Console.ReadLine() ?? "";
            string[] parts = marksInput.Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length >= 3)
            {
                student.PhysicsMarks = Convert.ToDouble(parts[0]);
                student.ChemistryMarks = Convert.ToDouble(parts[1]);
                student.ComputerApplicationMarks = Convert.ToDouble(parts[2]);
            }
            else if (parts.Length == 1)
            {
                student.PhysicsMarks = Convert.ToDouble(parts[0]);
                Console.Write("Input the marks of Chemistry : ");
                student.ChemistryMarks = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input the marks of Computer Application : ");
                student.ComputerApplicationMarks = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Invalid marks input. Please provide 3 numeric values.");
                return;
            }

            Console.WriteLine();
            student.DisplayReport();
        }
    }
}

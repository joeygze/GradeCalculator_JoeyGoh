using System;

// This program calculates the letter grade based on a numeric score input by the user.

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Student Grade Calculator ===");
            Console.Write("Enter your score (0-100): ");
            int score = int.Parse(Console.ReadLine());

            string grade;
            if (score >= 90) grade = "A";
            else if (score >= 80) grade = "B";
            else if (score >= 70) grade = "C";
            else if (score >= 60) grade = "D";
            else grade = "F";

            Console.WriteLine($"Your grade is: {grade}");

            // Average Score Calculation

            Console.Write("Enter number of assignments: ");
            int assignments = int.Parse(Console.ReadLine());
            double average = (double)score / assignments;
            Console.WriteLine($"Average score: {average:F2}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
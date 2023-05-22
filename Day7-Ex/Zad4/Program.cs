using System;

namespace Zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryNumber = int.Parse(Console.ReadLine());
            string nameOfPresentation = Console.ReadLine();

            double allGradesSum = 0;
            int gradeCounter = 0;

            while (nameOfPresentation != "Finish")
            {
                double gradesSum = 0;

                for (int i = 0; i < juryNumber; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradesSum += grade;
                    allGradesSum += grade;
                    gradeCounter++;
                }

                double averageGrade = gradesSum / juryNumber;

                Console.WriteLine($"{nameOfPresentation} - {averageGrade:f2}.");

                nameOfPresentation = Console.ReadLine();
            }

            double assessment = allGradesSum / gradeCounter;

            Console.WriteLine($"Student's final assessment is {assessment:f2}.");
        }
    }
}

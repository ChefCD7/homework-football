using System;
using System.Security.Cryptography.X509Certificates;

namespace Zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();

            int currentGrade = 1;
            int repeats = 0;
            double marksSum = 0;
            bool isExcluded = false;
            while (currentGrade <= 12)
            {
                double currentMark = double.Parse(Console.ReadLine());
                if (currentMark < 4)
                {
                    repeats++;
                    if (repeats > 1)
                    {
                        isExcluded= true;
                        break;
                    }

                    continue;
                }

                marksSum += currentMark;
                currentGrade++;

            }

            if (isExcluded)
            {
                Console.WriteLine($"{studentName} has been excluded at {currentGrade} grade");
            }
            else
            {
                double average = marksSum / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {average:f2}");
            }
        }
    }
}

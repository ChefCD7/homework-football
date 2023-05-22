using System;

namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int allowedFails = int.Parse(Console.ReadLine());

            int fail = 0;
            int overallScore = 0;
            int problemsCount = 0;

            string input = Console.ReadLine();
            string lastProblem = string.Empty;

            int score;
            while (input != "Enough")
            {
                lastProblem = input;
                
                score = int.Parse(Console.ReadLine());
                
                overallScore += score;
                
                problemsCount++;
                
                if (score <= 4)
                {
                    fail++;
                    
                    if (fail == allowedFails)
                    {
                        Console.WriteLine($"You need a break, {fail} poor grades.");
                        break;
                    }
                }
                
                
                input = Console.ReadLine();
            }
            
            if (input == "Enough")
            {
                Console.WriteLine($"Average score: {(double)overallScore / problemsCount:f2}");
                Console.WriteLine($"Number of problems: {problemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            
        }
    }
}

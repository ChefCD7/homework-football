using System;

namespace Exam_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfLocations = int.Parse(Console.ReadLine());

            int goldCount = 0;
            
            double sumGoldPerDay = 0;
            
            double averageGoldPerDay = 0;
            
            for (int i = 0; i < numbersOfLocations; i++)
            {
                double expectedAverageGoldPerDay = double.Parse(Console.ReadLine());
                
                int daysMining = int.Parse(Console.ReadLine());
                
                for (int j = 0; j < daysMining; j++)
                {
                    double goldMinedPerDay = double.Parse(Console.ReadLine());
                    
                    goldCount++;
                    
                    sumGoldPerDay += goldMinedPerDay;
                }
                
                averageGoldPerDay = sumGoldPerDay / goldCount;
                
                if (averageGoldPerDay >= expectedAverageGoldPerDay)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageGoldPerDay:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {(expectedAverageGoldPerDay - averageGoldPerDay):f2} gold.");
                }
                goldCount = 0;
                sumGoldPerDay = 0;
                averageGoldPerDay = 0;
            }
        }
    }
}

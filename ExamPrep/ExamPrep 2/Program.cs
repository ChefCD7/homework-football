using System;

namespace ExamPrep_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutesWalkingPerDay = int.Parse(Console.ReadLine());
            int numberOfWalksDaily = int.Parse(Console.ReadLine());
            int consumedCaloriesPerDay = int.Parse(Console.ReadLine());

            int minutesWalked = minutesWalkingPerDay* numberOfWalksDaily;
            int burntCaloriesPerDay = minutesWalked * 5;
            int minimumCalories = (50 *consumedCaloriesPerDay)/100;
            if (burntCaloriesPerDay >= minimumCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day:{burntCaloriesPerDay}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burntCaloriesPerDay}.");
            }
        }
    }
}

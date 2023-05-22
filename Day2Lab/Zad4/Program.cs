using System;
using System.Diagnostics.CodeAnalysis;

namespace Zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ekzkurziya = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddies = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int shipments = puzzles + dolls + teddies + minions + trucks;
            
            double sum = puzzles * 2.60 + dolls * 3 + teddies * 4.10 + minions * 8.20 + trucks * 2;
            
            if (shipments >= 50)
            {
                sum = sum - sum * 0.25;
            }

            sum = sum - sum * 0.10;

            if (sum > ekzkurziya)
            {
                Console.WriteLine($"Yes! {Math.Abs(sum-ekzkurziya):f2} lv left.");
            }
            else if (sum < ekzkurziya)
            {
                
                Console.WriteLine($"Not enough money! {Math.Abs(ekzkurziya-sum):f2} lv needed.");
            }
            
        }
    }
}

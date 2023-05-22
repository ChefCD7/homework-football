using System;

namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int biggestNumber = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                
                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }

                
            }
            int sumWithoutMax = sum - biggestNumber;
            if (biggestNumber == sumWithoutMax)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {biggestNumber}");
            }
            else
            {
                int diff = Math.Abs(sumWithoutMax - biggestNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");

            }
        }
    }
}

using System;

namespace Zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dest;
            while((dest = Console.ReadLine()) != "End")
            {
                int savedMoney = 0;
                int budget = int.Parse(Console.ReadLine());

                while (savedMoney < budget)
                {
                    savedMoney += int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {dest}!");
            }
        }
    }
}

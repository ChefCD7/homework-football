using System;

namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double needMoney = double.Parse(Console.ReadLine());
            double avaliableMoney = double.Parse(Console.ReadLine());

            int daysCount = 0;
            int spendCount = 0;

            string input;
            double money;

            while (avaliableMoney < needMoney)
            {
                input = Console.ReadLine();

                money = double.Parse(Console.ReadLine());
                
                daysCount++;

                if (input == "spend")
                {
                    spendCount++;

                    if (spendCount == 5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine(daysCount);
                        break;
                    }

                    avaliableMoney -= money;

                    if (avaliableMoney < 0)
                    {
                        avaliableMoney = 0;
                    }
                }
                else
                {
                    avaliableMoney += money;
                    
                    spendCount = 0;
                }
            }

            if (avaliableMoney >= needMoney)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
        }
    }
}

using System;

namespace Zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washPrice = double.Parse(Console.ReadLine());
            int pricePerToy = int.Parse(Console.ReadLine());

            double moneySaved = 0;
            double moneyStolen = 0;
         
            for (int i = 0; i < age; i += 2)
            {
                moneySaved += age *= 5 - 1;
            }
            int toyCount = 0;
            for (int i = 1; i < age; i += 2)
            {
                toyCount += 1;
            }
            double toyMoneySaved = toyCount * pricePerToy;
            double allMoneySaved = (moneySaved + toyMoneySaved) - moneyStolen;
            if (allMoneySaved >= washPrice)
            {
                double N = allMoneySaved - washPrice;
                Console.WriteLine($"Yes! {N:f2}");
            }
            else
            {
                double M = washPrice - allMoneySaved;
                Console.WriteLine($"No! {M:f2}");
            }
            

        }
    }
}

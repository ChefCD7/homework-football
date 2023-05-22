using System;
using System.Net.Http.Headers;

namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerKind = Console.ReadLine();
            int flowerNumber = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceOfRoses = 5;
            double priceOfDahlias = 3.8;
            double priceOfTulips = 2.8;
            double priceOfNarcissus = 3;
            double priceOfGladiolus = 2.5;

            double finalPrice = 0;

            if (flowerKind == "Roses")
            {
                if (flowerNumber > 80)
                {
                    priceOfRoses *= 0.9;
                }
                finalPrice = flowerNumber * priceOfRoses;
            }
            else if (flowerKind == "Dahlias")
            {
                if (flowerNumber > 90)
                {
                    priceOfDahlias *= 0.85;
                }
                finalPrice = flowerNumber * priceOfDahlias;
            }
            else if (flowerKind == "Tulips")
            {
                if (flowerNumber > 80)
                {
                    priceOfTulips *= 0.85;
                }
                finalPrice = flowerNumber * priceOfTulips;
            }
            else if (flowerKind == "Narcissus")
            {
                if (flowerNumber < 120)
                {
                    priceOfNarcissus *= 1.15;
                }
                finalPrice = flowerNumber * priceOfNarcissus;
            }
            else if (flowerKind == "Gladiolus")
            {
                if (flowerNumber < 80)
                {
                    priceOfGladiolus *= 1.2;
                }
                finalPrice = flowerNumber * priceOfGladiolus;
            }

            double difference = Math.Abs(budget - finalPrice);
            if (budget >= finalPrice)
            {
                
                Console.WriteLine($"Hey, you have a great garden with {flowerNumber} {flowerKind} and {difference:f2} leva left.");
            }
            else
            {
                
                Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
            }
        }
    }
}

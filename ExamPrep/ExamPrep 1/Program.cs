using System;

namespace ExamPrep_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aviocompanyName = Console.ReadLine();
            int countTicketsAdults = int.Parse(Console.ReadLine());
            int countTicketsKids = int.Parse(Console.ReadLine());
            double netPriceAdult = double.Parse(Console.ReadLine());
            double priceForService = double.Parse(Console.ReadLine());

            double netPriceKids = netPriceAdult - ((netPriceAdult * 70)/100);
            double priceForAdultsWithService = netPriceAdult + priceForService;
            double priceForKidsWithService = netPriceKids + priceForService;
            double sumOfIncome = (priceForAdultsWithService * countTicketsAdults) + (priceForKidsWithService * countTicketsKids);
            double income = (sumOfIncome * 20)/100;

            Console.WriteLine($"The profit of your agency from {aviocompanyName} tickets is {income:f2} lv.");

        }
    }
}

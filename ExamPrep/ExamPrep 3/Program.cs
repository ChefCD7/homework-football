using System;

namespace ExamPrep_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceForLuggageMoreThanTwentieKilos = double.Parse(Console.ReadLine());
            double kilosOfLuggage = double.Parse(Console.ReadLine());
            int daysUntillTrip = int.Parse(Console.ReadLine());
            int luggageCount = int.Parse(Console.ReadLine());

            double luggageTaxes = 0;
            if (kilosOfLuggage <= 10)
            {
                if (daysUntillTrip < 7)
                {
                    priceForLuggageMoreThanTwentieKilos = priceForLuggageMoreThanTwentieKilos + ((40 * priceForLuggageMoreThanTwentieKilos) / 100);
                }
                else if ( daysUntillTrip > 7 && daysUntillTrip < 30 )
                {
                    priceForLuggageMoreThanTwentieKilos = priceForLuggageMoreThanTwentieKilos + ((15 * priceForLuggageMoreThanTwentieKilos) / 100);
                }
                else
                {
                    priceForLuggageMoreThanTwentieKilos = priceForLuggageMoreThanTwentieKilos + ((10 * priceForLuggageMoreThanTwentieKilos) / 100);
                }
                luggageTaxes = (20 * priceForLuggageMoreThanTwentieKilos) / 100;
            }
            else if (kilosOfLuggage > 10 && kilosOfLuggage < 20)
            {
                if (daysUntillTrip < 7)
                {
                    priceForLuggageMoreThanTwentieKilos = priceForLuggageMoreThanTwentieKilos + ((40 * priceForLuggageMoreThanTwentieKilos) / 100);
                }
                else if (daysUntillTrip > 7 && daysUntillTrip < 30)
                {
                    priceForLuggageMoreThanTwentieKilos = priceForLuggageMoreThanTwentieKilos + ((15 * priceForLuggageMoreThanTwentieKilos) / 100);
                }
                else
                {
                    priceForLuggageMoreThanTwentieKilos = priceForLuggageMoreThanTwentieKilos + ((10 * priceForLuggageMoreThanTwentieKilos) / 100);
                }
                luggageTaxes = (50 * priceForLuggageMoreThanTwentieKilos) / 100;
            }
            else
            {
                if (daysUntillTrip < 7)
                {
                    priceForLuggageMoreThanTwentieKilos = priceForLuggageMoreThanTwentieKilos + ((40 * priceForLuggageMoreThanTwentieKilos) / 100);
                }
                else if (daysUntillTrip > 7 && daysUntillTrip < 30)
                {
                    priceForLuggageMoreThanTwentieKilos = priceForLuggageMoreThanTwentieKilos + ((15 * priceForLuggageMoreThanTwentieKilos) / 100);
                }
                else
                {
                    priceForLuggageMoreThanTwentieKilos = priceForLuggageMoreThanTwentieKilos + ((10 * priceForLuggageMoreThanTwentieKilos) / 100);
                }
                luggageTaxes = priceForLuggageMoreThanTwentieKilos;
            }

            double priceToPay = luggageTaxes * luggageCount;
            Console.WriteLine($"The total price of bags is: {priceToPay:f2} lv.");

        }
    }
}

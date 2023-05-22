using System;
using System.IO;

namespace ExamPrep_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogramiCount = int.Parse(Console.ReadLine());
            string dogramiKind = Console.ReadLine();
            string nachinNaDostavyane = Console.ReadLine();

            
            
            double priceForOne = 0;
            if (dogramiKind == "90X130")
            {
                priceForOne = 110;
                if (dogramiCount > 30 && dogramiCount < 60)
                {
                    priceForOne -= (5 * priceForOne) / 100;
                }
                else if (dogramiCount > 60)
                {
                    priceForOne -= (8 * priceForOne) / 100;
                }
            }
            else if (dogramiKind == "100X150")
            {
                priceForOne = 140;
                if (dogramiCount > 40 && dogramiCount < 80)
                {
                    priceForOne -= (6 * priceForOne) / 100;
                }
                else if (dogramiCount > 80)
                {
                    priceForOne -= (10 * priceForOne) / 100;
                }
            }
            else if (dogramiKind == "130X180")
            {
                priceForOne = 190;
                if (dogramiCount > 20 && dogramiCount < 50)
                {
                    priceForOne -= (7 * priceForOne) / 100;
                }
                else if (dogramiCount > 50)
                {
                    priceForOne -= (12 * priceForOne) / 100;
                }
            }
            else if (dogramiKind == "200X300")
            {
                priceForOne = 250;
                if (dogramiCount > 25 && dogramiCount < 50)
                {
                    priceForOne -= (9 * priceForOne) / 100;
                }
                else if (dogramiCount > 50)
                {
                    priceForOne -= (14 * priceForOne) / 100;
                }
            }

            double priceToPay = dogramiCount * priceForOne;
            if (nachinNaDostavyane == "With delivery")
            {
                priceToPay += 60;
                if (dogramiCount > 99)
                {
                    priceToPay -= (4 * priceToPay) / 100;
                }
            }

            if (dogramiCount < 10)
            {
                Console.WriteLine("Invalid order");
            }
            else
            {
                Console.WriteLine($"{priceToPay:f2} BGN");
            }
        }
    }
}



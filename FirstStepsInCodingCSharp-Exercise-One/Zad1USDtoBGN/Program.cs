using System;

namespace Zad1USDtoBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем USD от конзолата
            double usd = double.Parse(Console.ReadLine());
            
            //2. Преобразуваме USD в BGN (1 USD = 1.79549 BGN)
            double bgn= usd * 1.79549;
            //3. Отпечатваме BGN на конзолата
            Console.WriteLine(bgn);

        }
    }
}

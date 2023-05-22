using System;

namespace Zad6Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylonQuantity = int.Parse(Console.ReadLine())+2;
            double paintLiters = double.Parse(Console.ReadLine());
            paintLiters = paintLiters + paintLiters *0.1; 
            int thinnerLiters = int.Parse(Console.ReadLine());
            int workingTime = int.Parse(Console.ReadLine());

            double nylonPrice = nylonQuantity * 1.50;
            double paintPrice = paintLiters * 14.50;
            double thinnerPrice = thinnerLiters * 5;

            double materials = nylonPrice + paintPrice + thinnerPrice + 0.40;

            double workingPrice = materials * 0.3 * workingTime;

            double totalSum = materials + workingPrice;
            Console.WriteLine(totalSum);

        }
    }
}

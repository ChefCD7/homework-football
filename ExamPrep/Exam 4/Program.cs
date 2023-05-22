using System;

namespace Exam_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCats = int.Parse(Console.ReadLine());

            int smallCats = 0;
            int bigCats = 0;
            int giantCats = 0;
            double catfoodPerDay = 0;
            for (int i = 0; i < numberOfCats; i++)
            {
                double gramsCatfood = double.Parse(Console.ReadLine());
                if (gramsCatfood >= 100 && gramsCatfood < 200)
                {
                    smallCats++;
                }
                else if (gramsCatfood >= 200 && gramsCatfood < 300)
                {
                    bigCats++;
                }
                else
                {
                    giantCats++;
                }
                catfoodPerDay += gramsCatfood;
            }

            double foodPrice = (catfoodPerDay / 1000) * 12.45;
            Console.WriteLine($"Group 1: {smallCats} cats.");
            Console.WriteLine($"Group 2: {bigCats} cats.");
            Console.WriteLine($"Group 3: {giantCats} cats.");
            Console.WriteLine($"Price for food per day: {foodPrice:f2} lv.");
        }
    }
}

using System;

namespace Zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeMeters = double.Parse(Console.ReadLine());

            double delay = Math.Floor(meters / 15) * 12.5;

            double recordIvan = meters * timeMeters + delay;

            if (record < recordIvan)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {recordIvan} seconds.");
            }
            else if (recordIvan <= record)
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(record - recordIvan)} seconds slower");
            }



        }
    }
}

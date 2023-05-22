using System;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + hour * 60;

            minutes = minutes + 15;

            hour = minutes / 60;
            minutes = minutes % 60;

            bool newDay = hour == 24;
            if (newDay)
            {
                Console.WriteLine($"0:{minutes:D2}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minutes:D2}");
            }
        }
    }
}

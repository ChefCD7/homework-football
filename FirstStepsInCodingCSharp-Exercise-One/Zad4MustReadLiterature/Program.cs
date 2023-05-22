using System;

namespace Zad4MustReadLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesperhour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalHours = pages / pagesperhour;

            int hoursPerDay = totalHours / days;

            Console.WriteLine(hoursPerDay);
        }
    }
}

using System;

namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            for (int i = n; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

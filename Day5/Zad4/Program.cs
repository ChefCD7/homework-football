using System;

namespace Zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sequenecNum = 1;
            while (sequenecNum <= n)
            {
                Console.WriteLine(sequenecNum);

                sequenecNum = (sequenecNum * 2) + 1;
            }
        }
    }
}

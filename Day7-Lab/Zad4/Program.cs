using System;

namespace Zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combNum = 0;
            int sum = 0;
            bool end = false;
            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    combNum++;
                    sum = i + j;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combNum} ({i} + {j} = {magicNumber})");
                        end = true;
                        break;
                    }
                }
                if (end == true)
                {
                    break;
                }
                if (i == m)
                {
                    Console.WriteLine($"{combNum} combinations - neither equals {magicNumber}");
                }
            }
        }
    }
}

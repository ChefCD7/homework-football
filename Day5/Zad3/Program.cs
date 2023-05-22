using System;

namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int input;

            int sum = 0;
            while (firstNumber > sum)
            {
                input = int.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine(sum);
        }
    }
}

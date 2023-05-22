using System;

namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                string currentNumber = i.ToString();

                int oddSum = 0;
                int evenSum = 0;

                for (int j = 0; j < currentNumber.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        oddSum += int.Parse(currentNumber[j].ToString());
                    }
                    else
                    {
                        evenSum += int.Parse(currentNumber[j].ToString());
                    }
                }

                if (oddSum == evenSum)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
        }
    }
}

using System;

namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sumPrime = 0;
            int sumNonPrime = 0;

            while (input != "stop")
            {
                int currentNumber = int.Parse(input);
                int primeCounter = 0;

                if (currentNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                if (currentNumber == 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                for (int i = 1; i <= currentNumber; i++)
                {
                    if (currentNumber % i == 0)
                    {
                        primeCounter++;
                    }
                }

                if (primeCounter == 2)
                {
                    sumPrime += currentNumber;
                }
                else
                {
                    sumNonPrime += currentNumber;
                }
                
                input= Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");

        }
    }
}

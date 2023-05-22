using System;

namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currentNumber = 1;
            bool isBigger = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (currentNumber > n)
                    {
                        isBigger = true;
                        break;
                    }
                    
                    Console.Write($"{currentNumber} ");
                    currentNumber++;
                    
                }

                if (isBigger == true)
                {
                    break;
                }
                
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Net;

namespace Zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            if (operation == "+" || operation == "-" || operation == "*")
            {
                int result = 0;
                string condition = "even";
                if (operation == "+")
                {
                    result = n1 + n2;
                }
                else if (operation == "-")
                {
                    result = n1 - n2;
                }
                else if (operation == "*")
                {
                    result= n1 * n2;
                }

                if (result % 2 != 0)
                {
                    condition= "odd";
                }
                Console.WriteLine($"{n1} {operation} {n2} = {result} - {condition}");
            }
            else 
            {
                double result = 0;
                
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else if (operation == "/")
                {
                     result = (double)n1 / n2;
                    Console.WriteLine($"{n1} {operation} {n2} = {result:f2}");
                }
                else if (operation == "%")
                {
                     result = n1 % n2;
                    Console.WriteLine($"{n1} {operation} {n2} = {result}");
                }

                

            }
        }
    }
}

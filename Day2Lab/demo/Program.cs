using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            //int num = 123;
            
            int thirdNumber = num % 10; //123%10 = 3
            
            int secondNumber = num%100/10; //123%100 = 23/10 = 2
            
            int firstNumber = num % 1000 / 100; //123%1000 = 123/100 = 1

            Console.WriteLine(thirdNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(firstNumber);
        }
    }
}

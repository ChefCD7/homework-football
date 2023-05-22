using System;

namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double personAge = double.Parse(Console.ReadLine());
            char personGender = char.Parse(Console.ReadLine());

            if (personGender == 'f')
            {
                if (personAge < 16)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
            else if (personGender == 'm')
            {
                if (personAge < 16)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }
        }
    }
}

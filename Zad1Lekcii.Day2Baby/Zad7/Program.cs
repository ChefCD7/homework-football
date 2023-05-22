using System;
using System.Text;

namespace Zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area;

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a*a;
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a*b;
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = r * r * Math.PI;

            }
            else
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b/2;
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}

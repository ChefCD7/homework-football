using System;

namespace Exam_Prep_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int red = 0;
            int orange = 0;
            int yellow = 0;
            int white = 0;
            int black = 0;
            int differentColor = 0;
            double TotalPoints = 0;
            for (int i = 0; i < n; i++)
            {
                string ballKind = Console.ReadLine();
                if (ballKind == "red")
                {
                    red++;
                    TotalPoints += 5;
                }
                else if (ballKind == "orange")
                {
                    orange++;
                    TotalPoints += 10;
                }
                else if (ballKind == "yellow")
                {
                    yellow++;
                    TotalPoints += 15;
                }
                else if (ballKind == "white")
                {
                    white++;
                    TotalPoints += 20;
                }
                else if (ballKind == "black")
                {
                    black++;
                    TotalPoints = Math.Floor(TotalPoints/2);
                }
                else
                {
                    differentColor++;
                }
            }

            Console.WriteLine($"Total points: {TotalPoints}");
            Console.WriteLine($"Red balls: {red}");
            Console.WriteLine($"Orange balls: {orange}");
            Console.WriteLine($"Yellow balls: {yellow}");
            Console.WriteLine($"White balls: {white}");
            Console.WriteLine($"Other colors picked: {differentColor}");
            Console.WriteLine($"Divides from black balls: {black}");

        }
    }
}

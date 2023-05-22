using System;

namespace Exam_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double spaceshipWight = double.Parse(Console.ReadLine());
            double spaceshipLenght = double.Parse(Console.ReadLine());
            double spaceshipHeight = double.Parse(Console.ReadLine());
            double avarageCosmonautHeight = double.Parse(Console.ReadLine());

            double spaceshipVolume = spaceshipHeight * spaceshipLenght * spaceshipWight;
            double roomVolume = (avarageCosmonautHeight + 0.40) * 2 * 2;
            double enoughSpace = Math.Floor(spaceshipVolume / roomVolume);

            if (enoughSpace >= 3 && enoughSpace <= 10)
            {
                Console.WriteLine($"The spacecraft holds {enoughSpace} astronauts.");
            }
            else if (enoughSpace < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}

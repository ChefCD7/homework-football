using System;

namespace Zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int apartments = int.Parse(Console.ReadLine());

            for (int currFl = floors; currFl >= 1; currFl--)
            {
                for (int currRoom = 0; currRoom < apartments; currRoom++)
                {
                    if (currFl == floors)
                    {
                        Console.Write($"L{currFl}{currRoom} ");
                    }
                    else if (currFl % 2 == 0)
                    {
                        Console.Write($"O{currFl}{currRoom} ");

                    }
                    else
                    {
                        Console.Write($"A{currFl}{currRoom} ");

                    }
                }

                Console.WriteLine();
            }
        }
    }
}

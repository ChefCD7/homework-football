using System;

namespace Zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourCame = int.Parse(Console.ReadLine());
            int minutesCame = int.Parse(Console.ReadLine());

            int timeExam = hourExam * 60 + minutesExam;
            int timeCame = hourCame * 60 + minutesCame;

            if (timeCame > timeExam)
            {
                Console.WriteLine("Late");
                if (timeCame - timeExam < 60)
                {
                    int minutes = timeCame- timeExam;
                    Console.WriteLine($"{minutes} minutes after the start");
                }
                else
                {
                    int hour = (timeCame- timeExam) / 60;
                    int minutes = (timeCame- timeExam) % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                }
            }
            else if (timeCame == timeExam || timeExam - timeCame <= 30)
            {
                Console.WriteLine("On time");
                if (timeExam - timeCame != 0)
                {
                    int minutes = timeExam - timeCame;
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
            else if (timeExam - timeCame > 30)
            {
                Console.WriteLine("Early");
                if (timeExam - timeCame < 60)
                {
                    int minutes = timeExam - timeCame;
                    Console.WriteLine($"{minutes} minutes before the start");
                }
                else
                {
                    int hour = (timeExam - timeCame) / 60;
                    int minutes = (timeExam - timeCame) % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours before the start");
                }

            }
        }
    }
}

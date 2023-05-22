using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace Exam_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hoursSpent = int.Parse(Console.ReadLine());
            int numberOfPeople = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            double pricePerHour = 0;
            if (month == "march" || month == "may" || month == "april")
            {
                if (timeOfDay == "day")
                {
                    pricePerHour = 10.5;
                    if (numberOfPeople >= 4)
                    {
                        pricePerHour -= (pricePerHour * 10) / 100;
                    }
                    
                    if (hoursSpent >= 5)
                    {
                        pricePerHour -= (pricePerHour * 50)/ 100;
                    }
                }
                else if (timeOfDay == "night")
                {
                    pricePerHour = 8.4;
                    if (numberOfPeople >= 4)
                    {
                        pricePerHour -= (pricePerHour * 10) / 100;
                    }
                   
                    if (hoursSpent >= 5)
                    {
                        pricePerHour -= (pricePerHour * 50) / 100;
                    }
                }
            }
            else if (month == "june" || month == "july" || month == "august")
            {
                if (timeOfDay == "day")
                {
                    pricePerHour = 12.6;
                    if (numberOfPeople >= 4)
                    {
                        pricePerHour -= (pricePerHour * 10) / 100;
                    }
                   
                    if (hoursSpent >= 5)
                    {
                        pricePerHour -= (pricePerHour * 50) / 100;
                    }
                }
                else if (timeOfDay == "night")
                {
                    pricePerHour = 10.2;
                    if (numberOfPeople >= 4)
                    {
                        pricePerHour -= (pricePerHour * 10) / 100;
                    }
                    
                    if (hoursSpent >= 5)
                    {
                        pricePerHour -= (pricePerHour * 50) / 100;
                    }
                }
            }

            double totalCost = (pricePerHour * numberOfPeople) * hoursSpent;
            Console.WriteLine($"Price per person for one hour: {pricePerHour:f2}");
            Console.WriteLine($"Total cost of the visit: {totalCost:f2}");
        }
    }
}

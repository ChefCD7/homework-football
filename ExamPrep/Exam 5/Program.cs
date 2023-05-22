using System;

namespace Exam_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            int numberAdults = 0;
            int numberKids = 0;
            int moneyForToys = 0;
            int moneyForSweaters = 0;
            string input;
            while ((input = Console.ReadLine()) != "Christmas")
            {
                int ageOfFamilyMember = int.Parse(input);
                
                if (ageOfFamilyMember <= 16)
                {
                    numberKids++;
                    moneyForToys += 5;
                }
                else if (ageOfFamilyMember >16 )
                {
                    numberAdults++;
                    moneyForSweaters += 15;
                }
            }

            Console.WriteLine($"Number of adults: {numberAdults}");
            Console.WriteLine($"Number of kids: {numberKids}");
            Console.WriteLine($"Money for toys: {moneyForToys}");
            Console.WriteLine($"Money for sweaters: {moneyForSweaters}");

        }
    }
}

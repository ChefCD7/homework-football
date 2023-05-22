using System;
namespace domashna;

    class Program
    {
        public static int Sss(int k)
        {
            Random r = new Random();
        int sum = 0;
        for (int i = 0; i < k; i++)
            {
                int number = r.Next();
                if (number > 9 && number < 100)
                {
                sum += number;
                }
            }
            return sum;
        }











    }

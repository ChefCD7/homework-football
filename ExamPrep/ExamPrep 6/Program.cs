using System;

namespace ExamPrep_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double countPaint = int.Parse(Console.ReadLine());
            double countTapeti = int.Parse(Console.ReadLine());
            double priceEdinChiftRakavici = double.Parse(Console.ReadLine());
            double priceEdnaChetka = double.Parse(Console.ReadLine());

            double sumPaint = countPaint * 21.50;
            double sumTapeti = countTapeti * 5.20;
            double countRakavici = Math.Ceiling((35 * countTapeti)/ 100);
            double countChetki = Math.Floor((48 * countPaint) / 100);
            double sumRakavici = countRakavici * priceEdinChiftRakavici;
            double sumChetki = countChetki* priceEdnaChetka;
            double sum = sumPaint + sumTapeti + sumChetki + sumRakavici;
            double dostavka = sum / 15;

            Console.WriteLine($"This delivery will cost {dostavka:f2} lv.");
        }
    }
}

using System;

namespace lab14._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число P: ");
            Double P = Convert.ToDouble(Console.ReadLine());
            double v = 1000;
            int k = 0;
            while (v < 1100)
            {
                v *= (1 + P / 100);
                k++;
            }
            Console.WriteLine($"Размер вклада {v}");
            Console.WriteLine($"Количество месяцев {k}");
        }
    }
}

using System;

namespace lab4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, sum, raz, pr, chas;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            x = Math.Pow(x, 2);
            y = Math.Pow(y, 2);
            sum = x + y;
            raz = x - y;
            pr = x * y;
            chas = x / y;
            Console.WriteLine("Сумма: {0}, Разность: {1}, Произведение: {2}, Частное: {3}", sum, raz, pr, chas);
        }
    }
}

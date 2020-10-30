using System;

namespace lab6._4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y1, y2;
            x = int.Parse(Console.ReadLine());
            // Задание 4
            y1 = 3 * (Math.Pow(x, 6)) - 6 * (Math.Pow(x, 2)) - 7;
            // Задание 5
            y2 = 4 * (Math.Pow((x - 3), 6)) - 7 * (Math.Pow((x - 3), 3)) + 2;
            Console.WriteLine("Значение первой функции:");
            Console.WriteLine(y1);
            Console.WriteLine("Значение второй функции:");
            Console.WriteLine(y2);
        }
    }
}

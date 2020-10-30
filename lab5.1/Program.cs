using System;

namespace lab5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, a, b, r;
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            a = Math.Abs(x2 - x1);
            b = Math.Abs(y2 - y1);
            r = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine("Расстояние между двумя точками: {0}", r);
            Console.ReadKey();
        }
    }
}

using System;

namespace lab5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, ac, bc, pr, x1, x2, x3, y1, y2, y3;
            Console.WriteLine("Координаты точки A:");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Координаты точки B:");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Координаты точки C:");
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());
            a = Math.Abs(x3 - x1);
            b = Math.Abs(y3 - y1);
            c = Math.Abs(x3 - x2);
            d = Math.Abs(y3 - y2);
            ac = Math.Sqrt((a * a) + (b * b));
            bc = Math.Sqrt((c * c) + (d * d));
            pr = ac * bc;
            Console.WriteLine("AC = {0}, BC = {1}", ac, bc);
            Console.WriteLine("Произведение длин AC И BC равна {0}", pr);
        }
    }
}

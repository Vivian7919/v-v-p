using System;

namespace lab5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, y1, y2, y3, a, b, c, S, P, PP;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Координаты точки A:");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Координаты точки B:");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Координаты точки C:");
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());
            double s = 2;
            a = Math.Abs(Math.Sqrt(Math.Pow((x3 - x1), s) + Math.Pow((y3 - y1), s)));
            b = Math.Abs(Math.Sqrt(Math.Pow((x3 - x2), s) + Math.Pow((y2 - y3), s)));
            c = Math.Abs(Math.Sqrt(Math.Pow((x2 - x1), s) + Math.Pow((y2 - y1), s)));
            P = a + b + c;
            PP = (a + b + c) / 2;
            S = Math.Abs(Math.Sqrt(PP * (PP - a) * (PP - b) * (PP - c)));
            Console.WriteLine("S = " + Math.Round(S, 3));
            Console.WriteLine("P = " + Math.Round(P, 3));
        }
    }
}

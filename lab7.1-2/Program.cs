using System;

namespace lab7._1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //7.1
            double a, pi, d;
            a = double.Parse(Console.ReadLine());
            pi = 3.14;
            d = (pi * a) / 180;
            Console.WriteLine("Задание 7.1: {0}", d);
            //7.2
            double b, g;
            b = double.Parse(Console.ReadLine());
            g = b * (180 / pi);
            Console.WriteLine("Задание 7.2: {0}", g);
        }
    }
}

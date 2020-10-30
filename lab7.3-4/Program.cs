using System;

namespace lab7._3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //7.3
            double x, a, y, kg;
            x = 5;
            a = 149;
            y = 9;
            kg = a / x;
            y = kg * y;
            Console.WriteLine("Ответ на задание 7.3: {0}", y);
            //7.4
            double v1 = 40, v2 = 70, s = 100, t = 60, r;
            r = s + v1 * t + v2 * t;
            Console.WriteLine("Ответ на задание 7.4: {0}", r);
        }
    }
}

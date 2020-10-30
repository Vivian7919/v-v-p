using System;

namespace lab7._5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 7.5");
            //7.5
            double a, b, x;
            x = 0;
            Console.WriteLine("Введите А:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите В:");
            b = double.Parse(Console.ReadLine());
            if (a != 0)
            {
                x = -b / a;
            }
            Console.WriteLine("Ответ: {0}", x);
            x = 0;
            double y = 0;
            //7.6
            Console.WriteLine("Задание 7.6");
            double a1, b1, c1, a2, b2, c2, D;
            Console.WriteLine("Введите A1:");
            a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите В1:");
            b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите C1:");
            c1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите A2:");
            a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите В2:");
            b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите C2:");
            c2 = double.Parse(Console.ReadLine());
            D = a1 * b2 - a2 * b1;
            if (D != 0)
            {
                x = (c1 * b2 - c2 * b1) / D;
                y = (a1 * c2 - a2 * c1) / D;
            }
            Console.WriteLine("Х равен: {0}", x);
            Console.WriteLine("У равен: {0}", y);
        }
    }
}

using System;
using System.ComponentModel.Design.Serialization;

namespace lab11._1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание11.1");
           int a, b;
            Console.Write("Введите число A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            b = Convert.ToInt32(Console.ReadLine());
            if ( a == b)
            {
                a = 0;
                b = 0;
            }
            if ( a!= b)
            {
                if (a > b)
                {
                    b = a;
                }
                if ( b > a)
                {
                    a = b;
                }
            }
            Console.WriteLine("A = " + a + " " + "AND" + " " + "B = " + b);
            Console.ReadLine();
            Console.WriteLine("Задание11.2");
            int A, B, C, s = 0;
            Console.Write("Введите число A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число C: ");
            C = Convert.ToInt32(Console.ReadLine());
            if ((A < B) && (A < C)) s = B + C;
            if ((B < A) && (B < C)) s = A + C;
            if ((C < A) && (C < B)) s = A + B;
            Console.WriteLine("НАИБОЛЬШАЯ CУММА РАВНА " + s);
            Console.ReadLine();
            Console.WriteLine("Задание11.3");
            Console.WriteLine("Введите координаты точки A:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B:");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты точки C:");
            int c1 = Convert.ToInt32(Console.ReadLine());
            if ((b1 - a1) < (c1 - a1))
            {
                Console.WriteLine($"B ближе к A, расстояние = {b1 - a1}");
            }
            else if ((b1 - a1) > (c1 - a1))
            {
                Console.WriteLine($"C ближе к А, расстояние = {c1 - a1}");
            }
            else
            {
                Console.WriteLine($"B и C находятся в одной точке, расстояние = {b1 - a1}");
            }
        }
    }
}

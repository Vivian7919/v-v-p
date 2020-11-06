using System;

namespace lab10._6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Задание10.6");
            Console.WriteLine("Введите целое число a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число c:");
            c = int.Parse(Console.ReadLine());
            if ((a * a == b * b + c * c) | (b * b == a * a + c * c) | (c * c == a * a + b * b))
            {
                Console.WriteLine("Треугольник (a,b,c) является прямоугольным"); 
            }
            else
            {
                Console.WriteLine("Треугольник (a,b,c) не является прямоугольным");
            }
            Console.WriteLine("Задание10.7");
            Console.WriteLine("Введите целое число a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число c:");
            c = int.Parse(Console.ReadLine());
            if ((a < b + c) & (b < a + c) & (c < a + b))
            {
                Console.WriteLine("Треугольник со сторонами a,b,c существует");
            }
            else 
            {
                Console.WriteLine("Треугольник со сторонами a,b,c не существует");
            }
        }
    }
}

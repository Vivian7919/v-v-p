using System;

namespace lab15._1_2
{
    class Program
    {
        public static void PowerA3(double A, out double B)
        {
            B = A * A * A;
        }
        public static double Sign(double X)
        {
            if (X < 0)
            {
                return -1;
            }
            if (X == 0)
            {
                return 0;
            }
            if (X > 0)
            {
                return 1;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 15.1");
            double b;
            for (double i = 4; i < 9; i++)
            {
                PowerA3(i, out b);
                Console.WriteLine($"{i}*{i}*{i} = {b}");
            }
            Console.WriteLine("Задание 15.2");
            Console.Write("Введите A: ");
            Double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите B: ");
            Double B = Convert.ToDouble(Console.ReadLine());
            double y = Sign(A) + Sign(B);
            Console.WriteLine($"Sign(A) + Sign(B) = {y}");
        }

    }
}

using System;

namespace lab13._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            double s = 0;
            double d;
            for (double i = 0; i <= N; i++)
            {
                d = Math.Pow(A, i);
                s += d;
            }
            Console.WriteLine(s);
        }
    }
}

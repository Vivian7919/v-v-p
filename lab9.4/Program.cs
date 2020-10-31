using System;

namespace lab9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, N;
            double S;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            N = (A / C) * (B / C);
            S = A * B-N * Math.Sqrt(C);
            Console.WriteLine("На прямоугольнике можно разместить {0} квадратов", N);
            Console.WriteLine("Площадь незанятой части прямоугольника равна {0}", S);
        }
    }
}

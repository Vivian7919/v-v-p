using System;

namespace lab13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N(> 0): ");
            double N = Convert.ToDouble(Console.ReadLine());
            N = N * 0.1 + 1;
            double s = 1.1;
            for (double i = 1.2; i <= N; i += 0.1)
            {
                s = s * i;
            }
            Console.WriteLine(s);
        }
    }
}

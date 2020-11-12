using System;

namespace lab13._5
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
            double c;
            for (double i = 0; i <= N; i++)
            {
                c = Math.Pow(A, i);
                s = s + Math.Pow(-1, i) * c;
            }
            Console.WriteLine(s);
        }
    }
}

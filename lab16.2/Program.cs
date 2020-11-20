using System;

namespace lab16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Перывй член A : ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Знаменатель D: ");
            int D = Convert.ToInt32(Console.ReadLine());
            Console.Write("Рвзмер массива N : ");
            int N = Convert.ToInt32(Console.ReadLine());
            double[] r = new double[N];
            for (int i = 0; i < N; i++)
            {
                r[i] = (double)A * Math.Pow((double)D, (double)i);
                Console.WriteLine($"r[{i}] = {r[i]}");
            }
        }
    }
}
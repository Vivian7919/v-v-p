using System;

namespace lab17._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] a = new int[N];
            for (int i = 0; i < N; i++)
            {
                a[i] = rand.Next(100);
                Console.Write($"{a[i]} ");
            }
            Console.Write("\nВведите число K: ");
            int K = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число L: ");
            int L = Convert.ToInt32(Console.ReadLine());
            int shag = L - K + 1;
            int sum = 0;
            L = L - 1;
            K = K - 1;
            while (K <= L)
            {
                sum += a[K];
                K++;
            }
            double b = (double)sum / (double)shag;
            Console.WriteLine($"Cреднее арифметическое {b}");
        }
    }
}

using System;

namespace lab16._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("размер массива N : ");
            int N = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] a = new int[N];
            for (int i = 0; i < N; i++)
            {
                a[i] = rand.Next(100);
                Console.Write($"{a[i]} ");
            }

            Console.WriteLine("\nнечетные:");
            for (int i = 0; i < N; i += 2)
            {
                Console.WriteLine($"а[{i + 1}] = {a[i]}");
            }
            Console.WriteLine("четные:");
            if (N % 2 == 0)
            {
                for (int i = 0; i < N; i += 2)
                {
                    Console.WriteLine($"a[{N - i}] = {a[N - i - 1]}");
                }
            }
            else
            {
                for (int i = 0; i < N - 1; i += 2)
                {
                    Console.WriteLine($"a[{N - i - 1}] = {a[N - i - 2]}");
                }
            }
        }
    }
}
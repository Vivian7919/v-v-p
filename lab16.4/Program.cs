using System;

namespace lab16._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива N : ");
            int N = Convert.ToInt32(Console.ReadLine());
            N = N - 1;
            Random rand = new Random();
            int[] mass = new int[N];
            for (int i = 0; i < N; i++)
            {
                mass[i] = rand.Next(100);
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"mass[{i + 1}] = {mass[i]}");
                Console.WriteLine($"mass[{N - i + 1}] = {mass[N - i - 1]}");
            }
        }
    }
}

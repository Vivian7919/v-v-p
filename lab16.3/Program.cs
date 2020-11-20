using System;

namespace lab16._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите размер массива N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] r = new int[N];
            r[0] = A;
            r[1] = B;

            for (int i = 2; i < N; i++)
            {
                r[i] = r[i - 1] + r[i - 2];
                Console.WriteLine($"r[{i}] = {r[i]}");
            }
        }
    }
}

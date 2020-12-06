using System;

namespace lab17._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] a = new int[N];
            int flag = 0;
            int min = -1;
            for (int i = 1; i < N; i += 2)
            {
                a[i - 1] = rand.Next(100);
                a[i] = rand.Next(100);
                Console.WriteLine($"{a[i - 1]} ");
                Console.WriteLine($"{a[i]} ");
                if (flag == 0)
                {
                    min = a[i];
                    flag = 1;
                }
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine($"Минимальный элемент с чётным номером:{min}");
        }
    }
}

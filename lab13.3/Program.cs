using System;

namespace lab13._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N(> 0): ");
            int N = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            int n = 1;
            while (s < N * N)
            {
                s = s + (2 * n - 1);
                Console.WriteLine($"сумма: {s}");
                n++;
            }
        }
    }
}

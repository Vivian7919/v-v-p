using System;

namespace lab16._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N(>0): ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int k = 1; k < N+1; k += 2)
            {
                Console.WriteLine(k);
            }
        }
    }
}

using System;

namespace lab14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            while (A <= B)
            {
                int t = A;
                while (t > 0)
                {
                    Console.Write($"{A} ");
                    t--;
                }
                A++;
                Console.Write("\n");
            }
        }
    }
}

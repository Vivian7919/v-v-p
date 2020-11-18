using System;

namespace lab14._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            while (A > B)
            {
                A -= B;
            }
            Console.WriteLine($"Длина: {A}");
        }
    }
}

using System;

namespace lab14._5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 14.5");
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            int x = A;
            int y = B;
            while (B != A)
            {
                if (A > B)
                {
                    A -= B;
                }
                if (B > A)
                {
                    B -= A;
                }
            }
            Console.WriteLine($"НОД {x} и {y} = {A}");
            Console.ReadLine();
            Console.WriteLine("Задание 14.6");
            Console.Write("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int F = 0, f1 = 1, f2 = 1, k = 2;
            while (F < N)
            {
                k++;
                F = f2 + f1;
                f2 = f1;
                f1 = F;
            }
            Console.WriteLine(k);
        }
    }
}

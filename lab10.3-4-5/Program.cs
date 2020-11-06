using System;

namespace lab10._1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("Задание10.3");
            Console.WriteLine("Введите целое число А:");
            A = int.Parse(Console.ReadLine());
            if (A > 9 && A < 100 && A % 2 == 0)
            {
                Console.WriteLine("Высказывание - истинно");
            }
            else
            {
                Console.WriteLine("Высказывание - ложно");
            }
            Console.WriteLine("Задание10.4");
            Console.WriteLine("Введите целое число А:");
            A = int.Parse(Console.ReadLine());
            if ((A / 100 > (A % 100) / 10 && (A % 100) / 10 > A % 10) || (A / 100 < (A % 100) / 10 && (A % 100) / 10 < A % 10))
            {
                Console.WriteLine("Высказывание - истинно ");
            }
            else
            {
                Console.WriteLine("Высказывание - ложно ");
            }
            Console.WriteLine("Задание10.5");
            Console.WriteLine("Введите целое число А:");
            A = int.Parse(Console.ReadLine());
            if (A % 10 == A / 1000 & A % 100 / 10 == A % 1000 / 100)
            {
                Console.WriteLine("Высказывание - истинно ");
            }
            else
            {
                Console.WriteLine("Высказывание - ложно ");
            }
        }
    }
}

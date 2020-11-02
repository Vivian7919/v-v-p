using System;

namespace lab10._1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("Задание10.1");
            Console.WriteLine("Введите целое число А:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число В:");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine((A > 2) & (B <= 3));
            int C; 
            Console.WriteLine("Задание10.2");
            Console.WriteLine("Введите целое число А:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число В:");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число С:");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine((A < B) & (B < C));
        }
    }
}

using System;

namespace lab8._4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            //8.4
            Console.WriteLine("Введите двузначное число:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Ответ:");
            Console.WriteLine((A / 10) + (A % 10) * 10);
            //8.5
            Console.WriteLine("Введите трехзначное число:");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Ответ:");
            Console.WriteLine(((B / 100) * 10) + (((B % 100) / 10) * 100) + (B % 10));
        }
    }
}

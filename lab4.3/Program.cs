using System;

namespace lab4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sr;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            sr = (a + b) / 2;
            Console.WriteLine("Среднее арифметическое равно {0}", sr);
        }
    }
}

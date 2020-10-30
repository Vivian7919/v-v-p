using System;

namespace lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double d, L, pi;
            pi = 3.14;
            d = double.Parse(Console.ReadLine());
            L = pi * d;
            Console.WriteLine("L = {0}", L);
        }
    }
}

using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double S, P;
             a = int.Parse(Console.ReadLine());
             b = int.Parse(Console.ReadLine());
            S = a * b;
            P = 2 * (a + b);
            Console.WriteLine("S = {0}; P = {1}", S, P);
        }
    }
}

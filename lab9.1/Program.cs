using System;

namespace lab9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            n = int.Parse(Console.ReadLine());
            m = n / 60;
            Console.WriteLine(m + " минут");
        }
    }
}

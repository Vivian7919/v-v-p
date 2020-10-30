using System;

namespace lab6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 10, B = 100, C = 1000;
            int r, d;
            r = B;
            B = A;
            d = C;
            C = r;
            A = d;
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
    }
}

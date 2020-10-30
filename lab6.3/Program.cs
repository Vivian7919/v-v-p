using System;

namespace lab6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 123, B = 456, C = 789;
            int r, d;
            r = C;
            C = A;
            d = B;
            B = r;
            A = d;
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
    }
}

using System;

namespace lab6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, r;
            A = 201;
            B = 725;
            r = A;
            A = B;
            B = r;
            Console.WriteLine(A);
            Console.WriteLine(B);
        }
    }
}

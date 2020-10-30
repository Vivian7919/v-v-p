using System;

namespace lab8._2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //8.2
            int A, B, k;
            k = 0;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            while (A > B)
            {
                A = A - B;
                k += 1;
            }
            Console.WriteLine("Количество отрезков В: {0}", k);
            //8.2
            while (A - B >= 0)
            {
                A = A - B;
            }
            Console.WriteLine("Длина незанятой части : {0}", A);
        }
    }
}

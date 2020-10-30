using System;

namespace lab6._6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //6
            int A1, rez1;
            A1 = 3;
            A1 *= A1;
            A1 *= A1;
            A1 *= A1;
            rez1 = A1;
            Console.WriteLine("Задание 6: {0} ", rez1);
            //7
            double A2, rez2;
            A2 = 2;
            A2 = A2 * (Math.Pow(A2, 3)) * A2 * (Math.Pow(A2, 9)) * A2;
            rez2 = A2;
            Console.WriteLine("Задание 7: {0} ", rez2);
        }
    }
}

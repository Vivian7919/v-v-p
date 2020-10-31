using System;

namespace lab9._2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //9.2
            int k, a;
            Console.WriteLine("Задание 9.2:");
            Console.WriteLine("Введите число 1-365:");
            a = int.Parse(Console.ReadLine());
            k = a % 7;
            if (k == 0)
            {
                Console.WriteLine("День {0} является воскресеньем", a);
            }
            if (k == 1)
            {
                Console.WriteLine("День {0} является понедельником", a);
            }
            if (k == 2)
            {
                Console.WriteLine("День {0} является вторником", a);
            }
            if (k == 3)
            {
                Console.WriteLine("День {0} является средой", a);
            }
            if (k == 4)
            {
                Console.WriteLine("День {0} является четвергом", a);
            }
            if (k == 5)
            {
                Console.WriteLine("День {0} является пятницей", a);
            }
            if (k == 6)
            {
                Console.WriteLine("День {0} является субботой", a);
            }
            //9.3
            int K, N;
            Console.WriteLine("Задание 9.3:");
            Console.WriteLine("Введите число 1-365:");
            K = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 1-7:");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Номер дня: " + ((K + N - 2) % 7) + 1);
        }
    }
}

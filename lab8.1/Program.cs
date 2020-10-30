using System;

namespace lab8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, a;
            a = int.Parse(Console.ReadLine());
            k = a / 1024;
            if (a % 1024 != 0)
            {
                a++;
            }
            Console.WriteLine("Size = {0}", k);
        }
    }
}

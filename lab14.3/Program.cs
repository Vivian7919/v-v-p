using System;

namespace lab14._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int c = 1;
            while (sum < N)
            {
                sum = sum + c;
                c++;
            }
            if (sum > N)
            {
                sum -= c;
            }
            Console.WriteLine(sum);
            Console.WriteLine(c);
        }
    }
}

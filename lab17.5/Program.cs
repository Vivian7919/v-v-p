using System;

namespace lab17._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1, 39, 9, 39, 45};
            int N = 5;
            int ix = 0, jx = 0;
            for (int i = 1; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (a[i] == a[j])
                    {
                        ix = i;
                        jx = j;
                    }
                }
            }
            if (jx > ix)
            {
                Console.WriteLine($"Номер элементов: {jx} и {ix}");
            }
            else
            {
                Console.WriteLine($"Номер элементов: {ix} и {jx}");
            }
        }
    }
}

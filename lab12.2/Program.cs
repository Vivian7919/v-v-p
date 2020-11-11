using System;

namespace lab12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string C = Convert.ToString(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            string CC = "C";
            string[] d = new string[] { "C", "З", "Ю", "В" };
            for (int i = 0; i < 4; i++)
            {
                if (C == d[i])
                {
                    temp = i;
                }
            }
            if (C == CC && N == 1)
            {
                Console.WriteLine("В");
            }
            else
            {
                Console.WriteLine(d[(temp - N) % 4]);
            }
        }
    }
}

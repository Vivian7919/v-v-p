using System;

namespace lab23._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            string S0 = "";
            int a = -10;
            for (int i = 0; i < S.Length - 1; i++)
            {
                if (S[i] == ' ')
                {
                    if (i - 1 != a)
                    {
                        S0 += S[i - 1];
                    }
                    a = i + 1;
                    S0 += S[i + 1];
                }
            }
            Console.WriteLine(S0);
        }
    }
}

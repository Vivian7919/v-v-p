using System;

namespace lab23._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введиет строку S: ");
            string S = Console.ReadLine();
            Console.Write("Введиет строку S0: ");
            string S0 = Console.ReadLine();
            int a = 0;
            for (int i = 0; i < S.Length - S0.Length + 1; i++)
            {
                int k;
                k = 0;
                for (int j = 0; j < S0.Length; j++)
                {
                    if (S0[j] == S[i + j])
                    {
                        k++;
                    }
                }
                if (k == S0.Length)
                {
                    a += 1;
                    i = i + S0.Length - 1;
                }
            }
            Console.WriteLine($"количество вхождений: {a}");
        }
    }
}
using System;

namespace lab23._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("СИМВОЛ: ");
            char c;
            c = Convert.ToChar(Console.ReadLine());
            
            Console.Write("СТРОЧКА: ");
            char[] s;
            s = Console.ReadLine().ToCharArray();


            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    int Z = s.Length + 1;
                    Array.Resize(ref s, Z);
                    for (int j = s.Length - 2; j >= i; j--)
                    {
                        s[j + 1] = s[j];
                    }
                    i++;
                }

            }
            string res = new string(s);
            Console.WriteLine($"Новая строка: {res} ");
        }
    }
}
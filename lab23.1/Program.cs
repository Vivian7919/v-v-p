using System;

namespace lab23._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите С:");
            char C = Convert.ToChar(Console.ReadLine());
            Console.Write("Предыдущий символ  " + Convert.ToChar(C - 1));
            Console.WriteLine(" и следующий символ " + Convert.ToChar(C + 1));
        }
    }
}

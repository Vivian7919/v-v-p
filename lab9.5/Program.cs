using System;

namespace lab9._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            Console.WriteLine("Введите год:");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Hомер столетия: " + ((y - 1) / 1000) + 1);
        }
    }
}

using System;

namespace lab13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цену за 1 кг: ");
            int price = Convert.ToInt32(Console.ReadLine());
            for (double i = 0.1; i <= 1.0; i += 0.1)
            {
                Console.WriteLine($"{Math.Round(i, 1)}кг конфет стоит {price * Math.Round(i, 1)} рублей");
            }
        }
    }
}

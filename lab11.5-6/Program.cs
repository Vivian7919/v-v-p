using System;

namespace lab11._5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 11.5");
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            if (A != 0)
            {
                if (A > 0)
                {
                    Console.Write("Положительное ");
                }
                if (A < 0)
                {
                    Console.Write("Отрицательное ");
                }
                if (A % 2 == 0)
                {
                    Console.Write("Чётное");
                }
                if (A % 2 != 0)
                {
                    Console.Write("Нечётное");
                }
            }
            else
            {
                Console.WriteLine("Нулевое");
            }
            Console.ReadLine();
            Console.WriteLine("Задание 11.5");
            Console.Write("Введите число A: ");
            int A1 = Convert.ToInt32(Console.ReadLine());

            if (A1 % 2 == 0)
            {
                Console.Write("Чётное ");
            }
            else
            {
                Console.Write("Нечётное ");
            }
            if (A1 / 100 > 0)
            {
                Console.Write("трёхзначное число");
            }
            else if (A1 / 10 > 0)
            {
                Console.Write("двузначное число");
            }
            else
            {
                Console.Write("однозначное число");
            }
        }
    }
}

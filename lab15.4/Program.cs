﻿using System;

namespace lab15._4
{
    class Program
    {
        public static int Quarter(int x, int y)
        {
            if (x > 0)
            {
                if (y > 0)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
            else
            {
                if (y > 0)
                {
                }
                else
                {
                     return 3;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите x1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y1 : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите x2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y2 : ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите x3 : ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y3 : ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"(x1, y1) - {Quarter(x1, y1)} четверти");
            Console.WriteLine($"(x2, y2) - {Quarter(x2, y2)} четверти");
            Console.WriteLine($"(x3, y3) - {Quarter(x3, y3)} четверти");
        }
    }
}

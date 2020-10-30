using System;

namespace lab4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            int a1, a2, sum, raz, pr, chas;
            a1 = int.Parse(Console.ReadLine());
            a2 = int.Parse(Console.ReadLine());
            a1 = Math.Abs(a1);
            a2 = Math.Abs(a2);
            sum = a1 + a2;
            raz = a1 - a2;
            pr = a1 * a2;
            chas = a1 / a2;
            Console.WriteLine("Сумма: {0}, Разность: {1}, Произведение: {2},Частное: {3}", sum, raz, pr, chas);
        }
    }
}

﻿using System;

namespace lab12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер дня : ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());
            string[] den = new string[31]
            {
            "Первое",
            "Второе",
            "Третье",
            "Четвертое",
            "Пятое",
            "Шестое",
            "Седьмое",
            "Восьмое",
            "Девятое",
            "Десятое",
            "Одиннадцатое",
            "Двеннадцатое",
            "Триннадцатое",
            "Четырнадцатое",
            "Пятнадцатое",
            "Шестнадцатое",
            "Семнадцатое",
            "Восемнадцатое",
            "Девятнадцатое",
            "Двадцатое",
            "Двадцатьпервое",
            "Двадцатьвторое",
            "Двадцатьтретье",
            "Двадцатьчетвёртое",
            "Двадцатьпятое",
            "Двадцатьшестое",
            "Двадцатьседьмое",
            "Двадцатьвосьмое",
            "Двадцатьдевятое",
            "Тридцатое",
            "Тридцатьпервое"
            };
            string[] mes = new string[12]
            { 
                "января",
                "февраля",
                "марта",
                "апреля",
                "мая",
                "июня",
                "июля",
                "августа",
                "сентября",
                "октября",
                "ноября",
                "декабря" 
            };
            Console.WriteLine($"{den[d - 1]} {mes[m - 1]}");
        }
    }
}
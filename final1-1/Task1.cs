//Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

//Очень много вопросов к заданию. Буду считать, что просят
// ввод целых чисел с консоли
// числа входят в промежуток
//

using System;

class Program
{
    static void Main(string [] arg)
    {
        Console.WriteLine("Введите два числа (M и N):");
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int smaller = Math.Min(m, n);
        int larger = Math.Max(m, n);

        Console.WriteLine($"Натуральные числа от {smaller} до {larger}:");
        PrintNaturalNumbers(smaller, larger);
    }

    static void PrintNaturalNumbers(int start, int end)
    {
        if (start <= end)
        {
            Console.Write(start + " ");
            PrintNaturalNumbers(start + 1, end);
        }
    }
}
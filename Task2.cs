//Напишите программу вычисления функции Аккермана
//Даны два неотрицательных числа m и n. 
//Использовать рекурсию

//Буду считать, что просят
// ввод целых чисел с консоли
// я не поняла что такое функция Аккермана, поэтому правильность решения проверить не смогла

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите два неотрицательных числа m и n:");
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int result = AckermannFunction(m, n);

        Console.WriteLine($"Результат функции Аккермана для m = {m} и n = {n}: {result}");
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}
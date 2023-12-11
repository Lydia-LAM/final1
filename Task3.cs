//Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

//Буду считать, что просят
// ввод целых чисел с консоли
// я не поняла что такое функция Аккермана, поэтому правильность решения проверить не смогла

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размер массива:");
        int size = int.Parse(Console.ReadLine());
        int[] array = GenerateRandomArray(size);
        Console.WriteLine("Изначальный массив:");
        PrintArray(array, 0);
        Console.WriteLine("\nМассив элементов, начиная с конца:");
        PrintArrayReversed(array, array.Length - 1);
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 100);
        }

        return array;
    }

    static void PrintArray(int[] array, int index)
    {
        if (index < array.Length)
        {
            Console.Write(array[index] + " ");
            PrintArray(array, index + 1);
        }
    }

    static void PrintArrayReversed(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " ");
            PrintArrayReversed(array, index - 1);
        }
    }
}

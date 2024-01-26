using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(10);
        PrintArray(array);
        Console.WriteLine();
        PrintArrayReverse(array, array.Length - 1);
    }

    static int[] GenerateRandomArray(int length)
    {
        Random random = new Random();
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(100);
        }

        return array;
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine("Случайный массив: ");
        PrintArrayRecursive(array, 0);
    }

    static void PrintArrayRecursive(int[] array, int index)
    {
        if (index < array.Length)
        {
            Console.Write(array[index] + " ");
            PrintArrayRecursive(array, index + 1);
        }
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " ");
            PrintArrayReverse(array, index - 1);
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число M: ");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (M <= N)
        {
            PrintNumbersAsc(M, N);
        }
        else
        {
            PrintNumbersDesc(M, N);
        }
    }

    static void PrintNumbersAsc(int M, int N)
    {
        if (M <= N)
        {
            Console.Write(M);
            if (M < N)
            {
                Console.Write(", ");
            }
            PrintNumbersAsc(++M, N);
        }
    }

    static void PrintNumbersDesc(int M, int N)
    {
        if (M >= N)
        {
            Console.Write(M);
            if (M > N)
            {
                Console.Write(", ");
            }
            PrintNumbersDesc(--M, N);
        }
    }
}
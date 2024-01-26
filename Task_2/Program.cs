using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число m:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число n:");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = AckermannFunction(m, n);

        Console.WriteLine("m = " + m + ", n = " + n + "-> A(m,n) = " + result);
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}
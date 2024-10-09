using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What is number a (Minimum number)?");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("What is number b (Maximum number)?");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("What is number n?");
        int n = int.Parse(Console.ReadLine());

        var result = Task1(a, b, n);
        Console.WriteLine(result);
    }

    private static int Task1(int a, int b, int n)
    {
        int count = 0;
        int baseNum = 1;

        while (true)
        {
            double power = Math.Pow(baseNum, n);
            if (power > b)
                break;

            if (power >= a && power <= b)
                count++;

            baseNum++;
        }

        return count;
    }
}



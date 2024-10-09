using System;
using System.Collections.Generic; 

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

        Console.WriteLine("Please enter 6 letters:");
        string input = Console.ReadLine();

        if (input.Length == 6)
        {
            string upperCaseInput = input.ToUpper();
            Console.WriteLine("You entered (in uppercase): " + upperCaseInput);
            int totalPairsFromTask2 = Task2(upperCaseInput);
            Console.WriteLine($"Total pairs: {totalPairsFromTask2}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please make sure to enter exactly 6 letters.");
        }
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

    private static int Task2(string input)
    {
        var letterCounts = new Dictionary<char, int>();

        foreach (char letter in input)
        {
            if (letterCounts.ContainsKey(letter))
            {
                letterCounts[letter]++;
            }
            else
            {
                letterCounts[letter] = 1;
            }
        }

        int totalPairs = 0;

        foreach (var count in letterCounts.Values)
        {
            totalPairs += count / 2; 
        }

        return totalPairs;
    }

    private static int CountPairs(string input)
    {
        return 0; 
    }
}




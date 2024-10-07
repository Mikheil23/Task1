using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Task 1: Calculate the area difference between the big and small squares
        CalculateSquareAreaDifference();

        // Task 2: Check if the user hit the jackpot
        CheckJackpot();

        // Task 3: Calculate the total points for a football team
        CalculateFootballPoints();
    }

    static void CalculateSquareAreaDifference()
    {
        Console.WriteLine("Please enter circle radius:");
        var r = Convert.ToDouble(Console.ReadLine());
        var bigSquareSide = r * 2;
        var bigSquareArea = Math.Pow(bigSquareSide, 2);
        Console.WriteLine($"Big square area is: {bigSquareArea:F2}"); // F2 გვეხმარება რიცხვი ჩავწეროთ როგორც: 50.00 (ბოლოშო ორზე მეტი ნული არ იქნება.
        var smallSquareSide = r * Math.Sqrt(2);
        var smallSquareArea = Math.Pow(smallSquareSide, 2);
        Console.WriteLine($"Small square area is: {smallSquareArea:F2}");
        Console.WriteLine($"Difference between Big and Small square areas is: {bigSquareArea - smallSquareArea:F2}");
    }
    static void CheckJackpot()
    {      List<string> Jackpotlist = new List<string>();
        Console.WriteLine("Please enter symbols (enter an empty line to finish):");
        while (true)
        {
            var input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                Jackpotlist.Add(input);
            else
                break;
        }
        Dictionary<string, int> uniquesymbols = new Dictionary<string, int>();
        foreach (var symbol in Jackpotlist)
        {
            if (!uniquesymbols.ContainsKey(symbol))
                uniquesymbols[symbol] = 1;
            else
                uniquesymbols[symbol]++;
        }
        if (uniquesymbols.Count == 1 && uniquesymbols.First().Value == Jackpotlist.Count)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
    static void CalculateFootballPoints()
    {
        const int pointsPerWin = 3;
        const int pointsPerDraw = 1;
        Console.WriteLine("Please write how many matches your club won:");
        int wins = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please write how many matches your club drew:");
        int draws = Convert.ToInt32(Console.ReadLine());
        int totalPoints = (pointsPerWin * wins) + (pointsPerDraw * draws);
        Console.WriteLine($"Your team has {totalPoints} points");
    }
}
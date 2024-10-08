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

        // Task 4: Calculate week salary total
        EmployeeEarnings();

        // Task 5: Giorgi improvement
        List<int> hours = new List<int>();
        Console.WriteLine("Enter hours of improvement for each day (7 days):");
        for (int i = 0; i < 7; i++)
        {
            hours.Add(int.Parse(Console.ReadLine()));
        }
        Improvement(hours);

        // Task 6: Print n length elements
        ElementLength();
    }

    static void CalculateSquareAreaDifference()
    {
        Console.WriteLine("Please enter circle radius:");
        var r = Convert.ToDouble(Console.ReadLine());
        var bigSquareSide = r * 2;
        var bigSquareArea = Math.Pow(bigSquareSide, 2);
        Console.WriteLine($"Big square area is: {bigSquareArea:F2}"); // F2 აწერინებს რიცხვს როგორც 50.00
        var smallSquareSide = r * Math.Sqrt(2);
        var smallSquareArea = Math.Pow(smallSquareSide, 2);
        Console.WriteLine($"Small square area is: {smallSquareArea:F2}");
        Console.WriteLine($"Difference between Big and Small square areas is: {bigSquareArea - smallSquareArea:F2}");
    }

    static void CheckJackpot()
    {
        List<string> Jackpotlist = new List<string>();
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

    static void EmployeeEarnings()
    {
        Console.WriteLine("Enter how many hours you have worked this week");
        int onehourpay = 10;
        int overtimepay = 5;
        int weekendspay = 20;
        int[] workinghours = new int[7];
        int sum = 0;

        for (int i = 0; i < workinghours.Length; i++)
        {
            workinghours[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            if (workinghours[i] > 8)
            {
                sum += (8 * onehourpay) + ((workinghours[i] - 8) * (onehourpay + overtimepay));
            }
            else
            {
                sum += workinghours[i] * onehourpay;
            }
        }

        if (workinghours[5] > 0)
        {
            sum += workinghours[5] * weekendspay;
        }
        if (workinghours[6] > 0)
        {
            sum += workinghours[6] * weekendspay;
        }

        Console.WriteLine("Your total salary for this week is " + sum);
    }

    static void Improvement(List<int> hours)
    {
        var progress = 0;
        for (int i = 1; i < hours.Count; i++)
        {
            if (hours[i] > hours[i - 1])
            {
                progress++;
            }
        }
        Console.WriteLine($"output: {progress}");
    }
    static void ElementLength()
    {
        Console.WriteLine("Please enter length of N");
        int n = int.Parse(Console.ReadLine());
        List<string> words = new List<string> { "Hello","World","Programming","Communication"};
        var result = words.Where(word => word.Length >= n);
        if (result.Any())
        {
            Console.WriteLine(string.Join(", ", result));
        }
        else
        {
            Console.WriteLine("No elements found");
        }
    }
}

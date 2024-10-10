using System;
using System.Collections.Generic; 

internal class Program
{
    private static void Main(string[] args)
    {
     // Task1
        Console.WriteLine("What is number a (Minimum number)?");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("What is number b (Maximum number)?");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("What is number n?");
        int n = int.Parse(Console.ReadLine());
        var result = Task1(a, b, n);
        Console.WriteLine(result);
    // Task2
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
     // Task3
        Console.WriteLine("Write word#1");
        var word1 = Console.ReadLine();
        Console.WriteLine("Write word#2");
        var word2 = Console.ReadLine();

      
        string commonSuffix = Task3(word1, word2);

      
        if (!string.IsNullOrEmpty(commonSuffix))
        {
            Console.WriteLine("Matched combination: " + commonSuffix);
        }
        else
        {
            Console.WriteLine("No matching combination found.");
        }
     // Task4
        List<string> stringList = new List<string>();
        Task41(stringList);

       
        List<string> numberList = new List<string>();
        List<int> sumList = Task42(numberList);

        
        Console.WriteLine("Sum results:");
        foreach (var sum in sumList)
        {
            Console.WriteLine(sum);
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

    static string Task3(string word1, string word2)
    {
        int i = word1.Length - 1;
        int j = word2.Length - 1;
        string commonSuffix = string.Empty;

        
        while (i >= 0 && j >= 0 && word1[i] == word2[j])
        {
            commonSuffix = word1[i] + commonSuffix;
            i--;
            j--;
        }

        return commonSuffix;
    }
   
    static void Task41(List<string> stringList)
    {
    
        stringList.Add("Sport");
        stringList.Add("Math");
        stringList.Add("Art");

     
        foreach (string word in stringList)
        {
            Console.WriteLine(word.ToUpper());
        }
    }


    static List<int> Task42(List<string> numberList)
    {
        numberList.Add("5.5");
        numberList.Add("6.1");

        List<int> sumList = new List<int>(); 

        foreach (string number in numberList)
        {
          
            string[] parts = number.Split('.');
            if (parts.Length == 2)
            {
           
                int sum = 0;

              
                foreach (char digit in parts[0])
                {
                    if (char.IsDigit(digit))
                    {
                        sum += (digit - '0'); 
                    }
                }

             
                foreach (char digit in parts[1])
                {
                    if (char.IsDigit(digit))
                    {
                        sum += (digit - '0'); 
                    }
                }

                sumList.Add(sum); 
            }
        }

        return sumList; 
    }
}




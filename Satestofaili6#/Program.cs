using System;
using System.IO;

namespace Satestofaili6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }

        private static void Task1()
        {
            string filename = @"C:\Users\MYCOMPUTER\source\repos\satestofaili\Satestofaili6#\My folder\test..txt";
            string[] ArrLines;
            int n;

            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            Console.WriteLine("Write how many lines do you want in File!!!");
            n = int.Parse(Console.ReadLine());
            ArrLines = new string[n];

            Console.WriteLine("Input {0} strings below: \n", n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("input line {0}:\n", i + 1);
                ArrLines[i] = Console.ReadLine();
            }

            File.WriteAllLines(filename, ArrLines);
            Console.WriteLine($"Last line is {filename}");

            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                Console.WriteLine("{0}", lines[n - 1]);
            }
            Console.WriteLine();
        }

        private static void Task2()
        {
            Console.Write("Input N: ");
            int N = int.Parse(Console.ReadLine());

            string fileName2 = @"C:\Users\MYCOMPUTER\source\repos\satestofaili\Satestofaili6#\My folder\test2.txt";

            using (StreamWriter writer = new StreamWriter(fileName2))
            {
                for (int i = 1; i <= 9; i++)
                {
                    for (int j = 1; j <= N; j++)
                    {
                        writer.Write($"{j} * {i} = {j * i}");

                        if (j < N)
                        {
                            writer.Write(" | ");
                        }
                    }
                    writer.WriteLine();
                }
            }

            Console.WriteLine($"complying machine is in {fileName2} File.");
        }
    }
}

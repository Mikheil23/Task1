using System.ComponentModel.Design;

Console.WriteLine("Please write array size");
var x = Convert.ToInt32(Console.ReadLine());
int[] arr1 = new int[x];
for (int i = 0; i < x; i++)
{
    Console.WriteLine($"Enter number {i + 1}:");
    arr1[i] = Convert.ToInt32(Console.ReadLine());
}
List<int> evenNumbers = new List<int>();
List<int> oddNumbers = new List<int>();
foreach (var number in arr1)
{
    if (number % 2 == 0)
    {
        evenNumbers.Add(number);
    }
    else {  oddNumbers.Add(number); }

}
int[] evenArray = evenNumbers.ToArray();
int[] oddArray = oddNumbers.ToArray();
Console.WriteLine("Even numbers:");
foreach (var even in evenArray)
{
    Console.WriteLine(even);
}

Console.WriteLine("Odd numbers:");
foreach (var odd in oddArray)
{
    Console.WriteLine(odd);
}

#region Task1
Console.Write("Please enter circle radius: ");
var r = Convert.ToDouble(Console.ReadLine());
var bigSquareSide = r * 2;
var bigSquareArea = Math.Pow(bigSquareSide, 2);
Console.WriteLine($"Big square area is: {bigSquareArea:F2}"); 
var smallSquareSide = r * Math.Sqrt(2);
var smallSquareArea = Math.Pow(smallSquareSide, 2);
Console.WriteLine($"Small square area is: {smallSquareArea:F2}"); 
Console.WriteLine($"Difference between Big and Small square areas is: {bigSquareArea - smallSquareArea:F2}");
#endregion
#region Task3
var x = 3;
var y = 1;
var z = 0;
var win = x;
var draw = y;
var lost = z;
Console.WriteLine("Please write how many matches your club won?");
var x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please write how many matches your club draw?");
var x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please write how many matches your club lost?");
var f1 = win * x1;
var f2 = draw * x2;
var f3 = f1 + f2;
Console.WriteLine($"Your team has {f3} points");
#endregion